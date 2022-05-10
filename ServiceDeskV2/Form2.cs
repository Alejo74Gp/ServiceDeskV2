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
    public partial class Form2 : Form
    {
        SqlConnection conexion = new SqlConnection("server=ADO\\SQLEXPRESS; database=SERVICEDESK; integrated security=true");
        public Form2(String documento, String id_usuario)
        {
            InitializeComponent();
            this.documento = documento;
            this.id_usuario = id_usuario;
        }

        String documento;
        String id;
        String id_usuario;

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT DESCRIPCION FROM EQUIPO WHERE ID_USUARIO = @ID_USUARIO", conexion);
            comando.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                Equipos.Items.Add(registro["DESCRIPCION"].ToString());
            }
            conexion.Close();  
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT EQUIPO.MODELO, EQUIPO.PROCESADOR, EQUIPO.ANTIVIRUS, EQUIPO.RAM, EQUIPO.DISCO_DURO as 'DISCO DURO', EQUIPO.POLEDIT, EQUIPO.BOARD, EQUIPO.SISTEMA_OPERATIVO as 'SISTEMA OPERATIVO', EQUIPO.FIREWIRE, EQUIPO.DISPOSITIVOS, EQUIPO.PROGRAMAS, AREA.NOMBRE as 'AREA ASIGNADA', EQUIPO.DESCRIPCION, EQUIPO.ID_EQUIPO FROM EQUIPO INNER JOIN AREA ON EQUIPO.ID_AREA = AREA.ID_AREA WHERE DESCRIPCION = @DESCRIPCION", conexion);
            comando.Parameters.AddWithValue("@DESCRIPCION", Equipos.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Modelo.Text = registro["MODELO"].ToString();
                Procesador.Text = registro["PROCESADOR"].ToString();
                Antivirus.Text = registro["ANTIVIRUS"].ToString();
                RAM.Text = registro["RAM"].ToString();
                DiscoDuro.Text = registro["DISCO DURO"].ToString();
                Poledit.Text = registro["POLEDIT"].ToString();
                Board.Text = registro["BOARD"].ToString();
                SistemaOperativo.Text = registro["SISTEMA OPERATIVO"].ToString();
                Firewire.Text = registro["FIREWIRE"].ToString();
                Dispositivos.Text = registro["DISPOSITIVOS"].ToString();
                Programas.Text = registro["PROGRAMAS"].ToString();
                Area.Text = registro["AREA ASIGNADA"].ToString();
                Descripcion.Text = registro["DESCRIPCION"].ToString();
                ID_EQUIPO.Text = registro["ID_EQUIPO"].ToString();
                id = ID_EQUIPO.Text;

                Siguiente.Visible = true;
            }
            else
            {
                MessageBox.Show("Compruebe los campos del documento para verificar el usuario.");
            }
            conexion.Close();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form3 frm = new Form3(documento, id, id_usuario);
            frm.Show();
        }
    }
}
