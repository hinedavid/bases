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
    public partial class auditarConsultas : Form
    {
        public auditarConsultas()
        {
            InitializeComponent();
        }

        private void auditarConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
             //manejo de excepciones
            try {
                //intenta abrir la base de datos
                
                //String query = "select * from userdatabase2013.USUARIO";
                String query = "select num_identificacion_paciente,nombre_paciente,nombre_medico,codigo_medico from ((scott.Participa NATURAL JOIN scott.CONSULTA) NATURAL JOIN scott.Paciente )NATURAL JOIN scott.Medico Where identificacion='" + txt_codigo_medico.Text + "'And fecha_consulta= '"+ date_consulta.Text +"'";
                Conexion.get_cmd().CommandText = query;
                Conexion.get_cmd().CommandType = CommandType.Text;
     
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = Conexion.get_cmd().ExecuteReader();
                 //***si se quiere en un dataset
                    //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(Conexion.get_cmd());
                


                 
                 if (reader.Read())
                 {
                 //    MessageBox.Show("Bien mongolito, hizo la consulta" + reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + reader[3].ToString());
                     //Conexion c = new Conexion(DR["usuario"].ToString(), DR["passwd"].ToString());
                     DataSet set = new DataSet();
                     set.Tables.Add("Tabla");
                     adapter.Fill(set, "Tabla");  //llena el conjunto con la respuesta de la consulta
                     this.dataGridView1.DataSource = set;
                     this.dataGridView1.DataMember = "Tabla";
                     this.dataGridView1.Refresh();
                     this.dataGridView1.Columns[0].HeaderText = "Nombre paciente";
                     this.dataGridView1.Columns[1].HeaderText = "Identificaciòn paciente";
                     this.dataGridView1.Columns[2].Visible = false;
                     this.dataGridView1.Columns[3].Visible = false;
                     
                     
                     //cerrar la conexiòn
                     c.Close();
        
              }
              else 
              {
                     MessageBox.Show("no hay consultas");
                     //cerrar la conexiòn
                     c.Close();
              }

    //Nos acordamos de cerrar la conexión en el caso de que todavía esté abierta
    
    
    
            
            }

            catch {
                // c = new Conexion();
                MessageBox.Show("ha ocurrido un error");
                //cerrar la conexiòn
                c.Close();
            }
            
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
