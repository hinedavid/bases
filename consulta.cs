using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class consulta : Form
    {
        string tipo;
        string cod_medico;
        string cedula;
        string tipo_ids;

        public consulta(string id_paciente)
        {
            InitializeComponent();
            this.label11.Text = id_paciente;
            cedula = id_paciente;
            this.consultas(id_paciente, Login.get_user());

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_nasegurado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Examenes E = new Examenes();
            E.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tratamento F5 = new tratamento(cedula,tipo,Login.get_user(),tipo_ids);
            F5.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_codigo_medico_Click(object sender, EventArgs e)
        {

        }

        private void consultas(string id_paciente,string id_medico)
        {

            
             //manejo de excepciones
            try {
                //intenta abrir la base de datos
                Conexion c = new Conexion();
                String query = "select codigo_medico,tipo_id,nombre_paciente,fdenac_paciente,tipo_identificacion from scott.Medico,scott.Paciente where num_identificacion_paciente='" + id_paciente + "'And identificacion='" + id_medico + "'";
                Conexion.get_cmd().CommandText = query;
                Conexion.get_cmd().CommandType = CommandType.Text;
                
     
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = Conexion.get_cmd().ExecuteReader();
                 //***si se quiere en un dataset
                    //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(Conexion.get_cmd());
                
                 
                 if (reader.Read())
                 {

                     lbl_codigo_medico.Text = reader[0].ToString();
                     cod_medico = reader[0].ToString();
                     tipo_ids = reader[1].ToString();
                     lbl_nombre_paciente.Text = reader[2].ToString();
                     DateTime FecActual = DateTime.Now;                    
                     DateTime FecPas = Convert.ToDateTime(reader[3].ToString());
                     lbl_edad.Text = Convert.ToString(FecActual.Year - FecPas.Year);
                     tipo = reader[4].ToString();
                              
                     //Conexion c = new Conexion(DR["usuario"].ToString(), DR["passwd"].ToString());
                     DataSet set = new DataSet();
                     set.Tables.Add("Tabla");
                     adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                     c.Close();                                  
 
        
                 }
                 else 
                 {
                    MessageBox.Show("no hay consultas"); 
                    c.Close();
                 }

    //Nos acordamos de cerrar la conexión en el caso de que todavía esté abierta
    
    
            
            }

            catch {
                // c = new Conexion();
                MessageBox.Show("soy el catch");
            }
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            string hora = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            //abre la conexiòn
            Conexion c = new Conexion();

            try{                
                string insertar = "Insert into scott.Consulta(fecha_consulta,hora_consulta) values('"+ fecha +"','"+hora+"')";
                Conexion.get_cmd().CommandText = insertar;
                Conexion.get_cmd().CommandType = CommandType.Text;
                Conexion.get_cmd().ExecuteNonQuery();
               // MessageBox.Show("insertado correctamente");

                insertar = "Insert into scott.diagnostico (descripcion_diagnostico,fecha) values('" + txt_descripcion.Text + "','" + fecha + "')";
                Conexion.get_cmd().CommandText = insertar;
                Conexion.get_cmd().CommandType = CommandType.Text;

                try
                {
                    Conexion.get_cmd().ExecuteNonQuery();
                  //  MessageBox.Show("insertado correctamente en la tabla diagnostico");
                }

                catch
                {
                    MessageBox.Show("soy el catch de diagnostico");
                }

                     try {
                //intenta abrir la base de datos
                
                //String query = "select * from userdatabase2013.USUARIO";
                         String query = "select MAX(codigo_consulta), MAX(codigo_diagnostico) from scott.consulta,scott.diagnostico ";
                    Conexion.get_cmd().CommandText = query;
                Conexion.get_cmd().CommandType = CommandType.Text;
                
     
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = Conexion.get_cmd().ExecuteReader();
                 //***si se quiere en un dataset
                    //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(Conexion.get_cmd());
                 if (reader.Read())
                 {

                     //     lbl_codigo_medico.Text = reader[0].ToString();
                     string cod_consulta = reader[0].ToString();
                     string cod_diagnostico = reader[1].ToString();
                   
                    // MessageBox.Show("codigos consulta y diagnostico :"+ cod_consulta +","+cod_diagnostico);

                     insertar = "Insert into scott.genera (codigo_diagnostico,codigo_consulta) values('" + cod_diagnostico  + "','" + cod_consulta + "')";
                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;
                     
                     try {
                         Conexion.get_cmd().ExecuteNonQuery();
                        // MessageBox.Show("insertado correctamente en la tabla genera");
                         //cierra la conexiòn
                         
                     }

                     catch {             
                        MessageBox.Show("soy el catch");
                    }

                     insertar = "Insert into scott.participa (num_identificacion_paciente,tipo_identificacion,codigo_consulta,identificacion,tipo_id) values('" + cedula + "','" + tipo + "','" + cod_consulta + "','" + Login.get_user() + "','" + tipo_ids + "')";
                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;

                     try
                     {
                         Conexion.get_cmd().ExecuteNonQuery();
                         //MessageBox.Show("insertado correctamente en la tabla participa");
                         c.Close();
                     }

                     catch
                     {
                         MessageBox.Show("soy el catch de participa");
                         c.Close();
                     }
          
    }
    else {MessageBox.Show("no hay consultas"); }

            }

            catch {
                // c = new Conexion();
                MessageBox.Show("soy el catch");
            }

            }
            catch
            {
                MessageBox.Show("soy el catch de la inserción");
            }

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
