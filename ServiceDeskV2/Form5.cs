using System;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceDeskV2
{
    public partial class Form5 : Form
    {
        SqlConnection conexion = new SqlConnection("server=ADO\\SQLEXPRESS; database=SERVICEDESK; integrated security=true");
        public Form5()
        {
            InitializeComponent();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT USUARIO.NOMBRE, APELLIDO, CORREO, TELEFONO, ESTADO.NOMBRE_ESTADO as ESTADO, CARGO.NOMBRE as CARGO FROM USUARIO INNER JOIN ESTADO ON USUARIO.ID_ESTADO = ESTADO.ID_ESTADO INNER JOIN CARGO ON  USUARIO.ID_CARGO = CARGO.ID_CARGO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Usuarios.DataSource= tabla;
            Crear.Visible = true;
            Eliminar.Visible = true;
        }

        private void GtCargos_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form11 frm = new Form11();
            frm.Show();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            /*try
            {
                String query = "INSERT INTO USUARIO (NOMBRE,ID_CARGO) VALUES (@NOMBRE,@ID_CARGO)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@NOMBRE", Nombre.Text);
                comando.Parameters.AddWithValue("@ID_CARGO", ID.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cargo registrado.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar el cargo.");
            }*/
        }
    }
}
