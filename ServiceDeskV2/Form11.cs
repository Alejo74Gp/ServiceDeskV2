using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceDeskV2
{
    public partial class Form11 : Form
    {
        SqlConnection conexion = new SqlConnection("server=ADO\\SQLEXPRESS; database=SERVICEDESK; integrated security=true");
        public Form11()
        {
            InitializeComponent();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT ID_CARGO as 'ID DEL CARGO', NOMBRE FROM CARGO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Cargos.DataSource = tabla;
            Crear.Visible = true;
            Eliminar.Visible = true;
        }

        private void Crear_Click(object sender, EventArgs e)
        {
                String query = "INSERT INTO CARGO (NOMBRE,ID_CARGO) VALUES (@NOMBRE,@ID_CARGO)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NOMBRE", Nombre.Text);
                comando.Parameters.AddWithValue("@ID_CARGO", ID.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cargo registrado.");
                conexion.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
                string query = "DELETE FROM CARGO WHERE ID_CARGO= @ID_CARGO AND NOMBRE= @NOMBRE";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ID_CARGO", ID.Text);
                comando.Parameters.AddWithValue("@NOMBRE", Nombre.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Cargo eliminado.");
        }
    }
}
