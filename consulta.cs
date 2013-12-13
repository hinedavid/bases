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
            tratamento F5 = new tratamento(cedula,tipo,cod_medico);
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
                
                String query = "select codigo_medico,nombre_paciente,fdenac_paciente,tipo_identificacion from edusdb.Medico,edusdb.Paciente where num_identificacion_paciente='" + id_paciente + "'And identificacion='"+ id_medico +"'";
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
                     lbl_nombre_paciente.Text = reader[1].ToString();
                     DateTime FecActual = DateTime.Now;                    
                     DateTime FecPas = Convert.ToDateTime(reader[2].ToString());
                     lbl_edad.Text = Convert.ToString(FecActual.Year - FecPas.Year);
                     tipo = reader[3].ToString();
                              
                     //Conexion c = new Conexion(DR["usuario"].ToString(), DR["passwd"].ToString());
                     DataSet set = new DataSet();
                     set.Tables.Add("Tabla");
                     adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                                                       
 
        
    }
    else {MessageBox.Show("no hay consultas"); }

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
            

            try{                
                string insertar = "Insert into edusdb.Consulta(fecha_consulta,hora_consulta) values('"+ fecha +"','"+hora+"')";
                Conexion.get_cmd().CommandText = insertar;
                Conexion.get_cmd().CommandType = CommandType.Text;
                Conexion.get_cmd().ExecuteNonQuery();
               // MessageBox.Show("insertado correctamente");

                insertar = "Insert into edusdb.diagnostico (descripcion_diagnostico,fecha) values('" + txt_descripcion.Text + "','" + fecha + "')";
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
                         String query = "select MAX(codigo_de_consulta), MAX(codigo_diagnostico) from edusdb.consulta,edusdb.diagnostico ";
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

                     insertar = "Insert into edusdb.genera (codigo_diagnostico,codigo_consulta) values('" + cod_diagnostico  + "','" + cod_consulta + "')";
                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;
                     
                     try {
                         Conexion.get_cmd().ExecuteNonQuery();
                        // MessageBox.Show("insertado correctamente en la tabla genera");
                     }

                     catch {             
                        MessageBox.Show("soy el catch");
                    }

                     insertar = "Insert into edusdb.participa (num_identificacion_paciente,tipo_identificacion,codigo_de_consulta,codigo_medico) values('" + cedula + "','" + tipo + "','" + cod_consulta + "','" + cod_medico + "')";
                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;

                     try
                     {
                         Conexion.get_cmd().ExecuteNonQuery();
                         //MessageBox.Show("insertado correctamente en la tabla participa");
                     }

                     catch
                     {
                         MessageBox.Show("soy el catch de participa");
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
