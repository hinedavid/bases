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
    public partial class Consultarsubordinados : Form
    {
        public Consultarsubordinados()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //manejo de excepciones
            try
            {
                //intenta abrir la base de datos

                //String query = "select * from userdatabase2013.USUARIO";
                String query = "select identificacion, tipo_idenficacion, codigo_medico, nombre_medico from edusdb.Medico Where codigo_medico_supervisor='" + txt_identificacion.Text + "'";
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
                    this.dataGridView1.Columns[0].HeaderText = "Identificación";
                    this.dataGridView1.Columns[1].HeaderText = "Tipo Identificación";
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
    }
}
