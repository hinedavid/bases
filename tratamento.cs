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
    public partial class tratamento : Form
    {
        string cedula;
        string tipo;
        string cedulaMed;
        string tipomed;
        public tratamento(string cedula1, string tipo1,string cedulaM,string tipoM)
        {
            InitializeComponent();
            cedula = cedula1;
            tipo = tipo1;
            cedulaMed = cedulaM;
            lbl_codigo_medico.Text = cedulaM;
            lbl_asegurado.Text = cedula1;
            tipomed = tipoM;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
             

            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void label_cantidad_Click(object sender, EventArgs e)
        {

        }

        private void lbl_codigo_medico_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //abrir conexión
            Conexion c = new Conexion();
            string insertar = "Insert into scott.tratamiento (descripcion_tratamiento) values('" + txt_descripcion.Text + "')";
            Conexion.get_cmd().CommandText = insertar;
            Conexion.get_cmd().CommandType = CommandType.Text;

            try
            {
                Conexion.get_cmd().ExecuteNonQuery();
                //MessageBox.Show("insertado correctamente en la tabla tratamiento");
            }

            catch
            {
                MessageBox.Show("soy el catch de tratamiento");
            }

             try {
                //intenta abrir la base de datos
                
                
                String query = "select MAX(codigo_tratamiento) from scott.tratamiento ";
                Conexion.get_cmd().CommandText = query;
                Conexion.get_cmd().CommandType = CommandType.Text;
                
     
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                OracleDataReader reader = Conexion.get_cmd().ExecuteReader();
                 //***si se quiere en un dataset
                    //Al adaptador hay que pasarle el string SQL y la Conexión
                OracleDataAdapter adapter = new OracleDataAdapter(Conexion.get_cmd());
                 if (reader.Read())
                 {
                     string cod_tratamiento = reader[0].ToString();
                     //MessageBox.Show("codigos consulta y diagnostico :"+ cod_consulta +","+cod_diagnostico);

                     insertar = "Insert into scott.toma (num_identificacion_paciente,tipo_identificacion,codigo_tratamiento) values('" + cedula + "','" + tipo + "','" + cod_tratamiento + "')";
                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;

                     try
                     {
                         Conexion.get_cmd().ExecuteNonQuery();
                         //MessageBox.Show("insertado correctamente en la tabla tratamiento");
                     }

                     catch
                     {
                         MessageBox.Show("soy el catch de tratamiento");
                     }

                     insertar = "Insert into scott.prescribe(identificacion,tipo_id,codigo_tratamiento) values('" + cedulaMed + "','" + tipomed + "','" + cod_tratamiento + "')";
                     Conexion.get_cmd().CommandText = insertar;
                     Conexion.get_cmd().CommandType = CommandType.Text;

                     try
                     {
                         Conexion.get_cmd().ExecuteNonQuery();
                        // MessageBox.Show("insertado correctamente en la tabla tratamiento");
                         c.Close();
                     }

                     catch
                     {
                         MessageBox.Show("soy el catch de tratamiento");
                     }
                  }           
            }
             catch
             {
                 MessageBox.Show("soy el catch de MAX tratamiento");
             }
             this.Close();
   }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

}
}