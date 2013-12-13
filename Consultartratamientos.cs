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
    public partial class Consultartratamientos : Form
    {
        public Consultartratamientos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //manejo de excepciones
            try
            {
                //intenta abrir la base de datos

                //String query = "select * from userdatabase2013.USUARIO";
                String query = "select codigo_tratamiento,descripcion_tratamiento,codigo_medico,nombre_medico from ( (edusdb.toma NATURAL JOIN edusdb.TRATAMIENTO)NATURAL JOIN edusdb.prescribe)NATURAL JOIN edusdb.Medico Where num_identificacion_paciente='" + txt_identificacion.Text +"'";
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
                    this.dataGridView1.Columns[0].HeaderText = "Còdigo de Tratamiento";
                    this.dataGridView1.Columns[1].HeaderText = "Descripción del Tratamiento";
                    this.dataGridView1.Columns[2].HeaderText = "Còdigo Mèdico";
                    this.dataGridView1.Columns[3].HeaderText = "Nombre del Mèdico";


                }
                else { MessageBox.Show("no hay consultas"); }

                //Nos acordamos de cerrar la conexión en el caso de que todavía esté abierta




            }

            catch
            {
                // c = new Conexion();
                MessageBox.Show("soy el catch");
            }
        }

        private void Consultartratamientos_Load(object sender, EventArgs e)
        {

        }
    }
}
