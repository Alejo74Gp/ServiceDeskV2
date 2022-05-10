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
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=ADO\\SQLEXPRESS; database=SERVICEDESK; integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

        String id_usuario;

        private void GtUsuarios_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form5 frm = new Form5();
            frm.Show();
        }

        private void Incidente_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form2 frm = new Form2(Documento.Text,id_usuario);
            frm.Show();
        }

        private void GtIncidentes_Click(object sender, EventArgs e)
        {

        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM USUARIO WHERE DOCUMENTO = @DOCUMENTO", conexion);
                comando.Parameters.AddWithValue("@DOCUMENTO", Documento.Text);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    String documento;
                    documento = Documento.Text;
                    Nombre.Text = registro["NOMBRE"].ToString();
                    Apellido.Text = registro["APELLIDO"].ToString();
                    Correo.Text = registro["CORREO"].ToString();
                    Telefono.Text = registro["TELEFONO"].ToString();
                    ID.Text = registro["ID_USUARIO"].ToString();
                    id_usuario= ID.Text;
                    MessageBox.Show("Usuario verificado.");
                    Incidente.Visible = true;
                }
                else
                {
                    MessageBox.Show("Compruebe los campos del documento para verificar el usuario.");
                }
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Compruebe los campos del documento para verificar el usuario.");
            }        
        }
    }
}
