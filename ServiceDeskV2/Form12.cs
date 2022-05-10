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
    public partial class Form12 : Form
    {
        SqlConnection conexion = new SqlConnection("server=ADO\\SQLEXPRESS; database=SERVICEDESK; integrated security=true");
        public Form12()
        {
            InitializeComponent();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT INCIDENTE.ID_INCIDENTE AS 'ID DEL INCIDENTE', EQUIPO.DESCRIPCION AS 'EQUIPO DEL INCIDENTE', TIPO_INCIDENTE.NOMBRE_TIPOINCIDENTE AS 'TIPO DE INCIDENTE', INCIDENTE.PROBLEMA, INCIDENTE.ACCIONES AS 'ACCIONES TOMADAS', USUARIO.DOCUMENTO AS 'DOCUMENTO DEL USUARIO QUE REPORTÓ', INCIDENTE.PREDIAGNOSTICO AS 'PREDIAGNOSTICO DEL INCIDENTE', MOTIVO.NOMBRE_MOTIVO AS 'MOTIVO DEL INCIDENTE', ESTADO.NOMBRE_ESTADO AS 'ESTADO DEL INCIDENTE', INCIDENTE.PRIORIDAD AS 'PRIORIDAD DEL INCIDENTE' FROM INCIDENTE INNER JOIN EQUIPO ON INCIDENTE.ID_EQUIPO = EQUIPO.ID_EQUIPO INNER JOIN TIPO_INCIDENTE ON INCIDENTE.ID_TIPOINCIDENTE = TIPO_INCIDENTE.ID_TIPOINCIDENTE INNER JOIN USUARIO ON INCIDENTE.ID_USUARIO = USUARIO.ID_USUARIO INNER JOIN MOTIVO ON INCIDENTE.ID_MOTIVO = MOTIVO.ID_MOTIVO INNER JOIN ESTADO ON INCIDENTE.ID_ESTADO = ESTADO.ID_ESTADO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Incidentes.DataSource = tabla;
        }
    }
}
