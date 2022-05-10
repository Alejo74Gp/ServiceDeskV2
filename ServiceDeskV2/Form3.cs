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
    public partial class Form3 : Form
    {
        SqlConnection conexion = new SqlConnection("server=ADO\\SQLEXPRESS; database=SERVICEDESK; integrated security=true");
        public Form3(String documento,String id, String id_usuario)
        {
            InitializeComponent();
            this.documento = documento;
            this.id = id;
            this.id_usuario = id_usuario;

        }

        String documento;
        String id;
        String id_usuario;
        String id_incidente;

        private void GtTipos_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT MOTIVO.NOMBRE_MOTIVO, ESTADO.NOMBRE_ESTADO, TIPO_INCIDENTE.NOMBRE_TIPOINCIDENTE FROM MOTIVO FULL OUTER JOIN ESTADO ON MOTIVO.NOMBRE_MOTIVO = ESTADO.NOMBRE_ESTADO FULL OUTER JOIN TIPO_INCIDENTE ON MOTIVO.NOMBRE_MOTIVO = TIPO_INCIDENTE.NOMBRE_TIPOINCIDENTE", conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                Motivo.Items.Add(registro["NOMBRE_MOTIVO"].ToString());
                Estado.Items.Add(registro["NOMBRE_ESTADO"].ToString());
                TipoIncidente.Items.Add(registro["NOMBRE_TIPOINCIDENTE"].ToString());
            }
            conexion.Close();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            String tipo_incidente, estado, motivo;
            SqlCommand comando2 = new SqlCommand("SELECT ID_TIPOINCIDENTE FROM TIPO_INCIDENTE WHERE NOMBRE_TIPOINCIDENTE = @NOMBRE_TIPOINCIDENTE", conexion);
            comando2.Parameters.AddWithValue("@NOMBRE_TIPOINCIDENTE", TipoIncidente.Text);
            SqlCommand comando3 = new SqlCommand("SELECT ID_MOTIVO FROM MOTIVO WHERE NOMBRE_MOTIVO = @NOMBRE_MOTIVO", conexion);
            comando3.Parameters.AddWithValue("@NOMBRE_MOTIVO", Motivo.Text);
            SqlCommand comando4 = new SqlCommand("SELECT ID_ESTADO FROM ESTADO WHERE NOMBRE_ESTADO = @NOMBRE_ESTADO", conexion);
            comando4.Parameters.AddWithValue("@NOMBRE_ESTADO", Estado.Text);
            conexion.Open();
            SqlDataReader registro = comando2.ExecuteReader();
            if (registro.Read())
            {
                Id_Tipoincidente.Text = registro["ID_TIPOINCIDENTE"].ToString();
                tipo_incidente = Id_Tipoincidente.Text;
            }
            conexion.Close();
            conexion.Open();
            SqlDataReader registro2 = comando3.ExecuteReader();
            if (registro2.Read())
            {
                Id_Motivosolicitud.Text = registro2["ID_MOTIVO"].ToString();
                motivo = Id_Motivosolicitud.Text;
            }
            conexion.Close();
            conexion.Open();
            SqlDataReader registro3 = comando4.ExecuteReader();
            if (registro3.Read())
            {
                Id_Estado.Text = registro3["ID_ESTADO"].ToString();
                estado = Id_Estado.Text;
            }
            conexion.Close();
            String query = "INSERT INTO INCIDENTE (ID_EQUIPO, ID_TIPOINCIDENTE, PROBLEMA, ACCIONES, ID_USUARIO, PREDIAGNOSTICO, ID_MOTIVO, ID_ESTADO, PRIORIDAD) VALUES (@ID_EQUIPO, @ID_TIPOINCIDENTE, @PROBLEMA, @ACCIONES, @ID_USUARIO, @PREDIAGNOSTICO, @ID_MOTIVO, @ID_ESTADO, @PRIORIDAD)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID_EQUIPO", id);
            comando.Parameters.AddWithValue("@ID_TIPOINCIDENTE", Id_Tipoincidente.Text);
            comando.Parameters.AddWithValue("@PROBLEMA", Problema.Text);
            comando.Parameters.AddWithValue("@ACCIONES", AccionesTomadas.Text);
            comando.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
            comando.Parameters.AddWithValue("@PREDIAGNOSTICO", Prediagnosticos.Text);
            comando.Parameters.AddWithValue("@ID_MOTIVO", Id_Motivosolicitud.Text);
            comando.Parameters.AddWithValue("@ID_ESTADO", Id_Estado.Text);
            comando.Parameters.AddWithValue("@PRIORIDAD", Prioridad.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Incidente registrado.");
            conexion.Close();
            /*
             * SqlCommand comando5 = new SqlCommand("SELECT ID_INCIDENTE FROM INCIDENTE WHERE ID_EQUIPO = @ID_EQUIPO AND ID_TIPOINCIDENTE = @ID_TIPOINCIDENTE AND PROBLEMA = @PROBLEMA AND ACCIONES = @ACCIONES AND ID_USUARIO = @ID_USUARIO AND PREDIAGNOSTICO = @PREDIAGNOSTICO AND ID_MOTIVO = @ID_MOTIVO AND ID_ESTADO = @ID_ESTADO AND PRIORIDAD = @PRIORIDAD", conexion);
            comando.Parameters.AddWithValue("@ID_EQUIPO", id);
            comando.Parameters.AddWithValue("@ID_TIPOINCIDENTE", Id_Tipoincidente.Text);
            comando.Parameters.AddWithValue("@PROBLEMA", Problema.Text);
            comando.Parameters.AddWithValue("@ACCIONES", AccionesTomadas.Text);
            comando.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
            comando.Parameters.AddWithValue("@PREDIAGNOSTICO", Prediagnosticos.Text);
            comando.Parameters.AddWithValue("@ID_MOTIVO", Id_Motivosolicitud.Text);
            comando.Parameters.AddWithValue("@ID_ESTADO", Id_Estado.Text);
            comando.Parameters.AddWithValue("@PRIORIDAD", Prioridad.Text);
            conexion.Open();
            SqlDataReader registro4 = comando5.ExecuteReader();
            if (registro4.Read())
            {
                Id_incidente.Text = registro4["ID_INCIDENTE"].ToString();
                id_incidente = Id_incidente.Text;
            }
        Form.ActiveForm.Visible = false;
        Form4 frm = new Form4(id_incidente);
        frm.Show();
            */
            Form.ActiveForm.Visible = false;
            Form12 frm = new Form12();
            frm.Show();
        }

        private void TipoIncidente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
