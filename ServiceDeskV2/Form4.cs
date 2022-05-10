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
    public partial class Form4 : Form
    {
        SqlConnection conexion = new SqlConnection("server=ADO\\SQLEXPRESS; database=SERVICEDESK; integrated security=true");
        public Form4( String id_incidente)
        {
            InitializeComponent();
            this.id_incidente = id_incidente;
        }

        String id_incidente;

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT INCIDENTE.ID_INCIDENTE, INCIDENTE.PRIORIDAD, INCIDENTE.PROBLEMA, ESTADO.NOMBRE_ESTADO, EQUIPO.DESCRIPCION, USUARIO.DOCUMENTO FROM INCIDENTE INNER JOIN ESTADO ON INCIDENTE.ID_ESTADO = ESTADO.ID_ESTADO INNER JOIN EQUIPO ON INCIDENTE.ID_EQUIPO = EQUIPO.ID_EQUIPO INNER JOIN USUARIO ON INCIDENTE.ID_USUARIO = USUARIO.ID_USUARIO WHERE ID_INCIDENTE = @ID_INCIDENTE", conexion);
            comando.Parameters.AddWithValue("@ID_INCIDENTE", id_incidente);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                NumeroIncidente.Text = registro["ID_INCIDENTE"].ToString();
                PrioridadIncidente.Text = registro["PRIORIDAD"].ToString();
                ProblemaIncidente.Text = registro["PROBLEMA"].ToString();
                EquipoIncidente.Text = registro["NOMBRE_ESTADO"].ToString();
                DocumentoUsuario.Text = registro["DESCRIPCION"].ToString();
                EstadoIncidente.Text = registro["DOCUMENTO"].ToString();
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
