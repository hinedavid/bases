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
    public partial class nuevaconsulta : Form
    {
        
        public nuevaconsulta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try{
            //abrir la conexión 
            Conexion c = new Conexion();
            String query = "select * from scott.PACIENTE Where num_identificacion_paciente = '" + txt_idpaciente.Text+"'";
            Conexion.get_cmd().CommandText = query;
            Conexion.get_cmd().CommandType = CommandType.Text;
            //Conexion.get_cmd().Parameters.Add("@id_pas", Oracle.DataAccess.Client.OracleDbType.NVarchar2, 9);
            //Conexion.get_cmd().Parameters[0].Value = txt_idpaciente.Text;
            
            //****Ejecutamos la consulta mediante un DataReader de Oracle
            OracleDataReader reader = Conexion.get_cmd().ExecuteReader();
            //***si se quiere en un dataset
            //Al adaptador hay que pasarle el string SQL y la Conexión
            OracleDataAdapter adapter = new OracleDataAdapter(Conexion.get_cmd());
           // DataSet set = new DataSet();
           // DataRow DR;
            //adapter.Fill(set, "paciente");  //llena el conjunto con la respuesta de la consulta
            //DR = set.Tables["paciente"].Rows[0];
            if ( reader.Read () )                
            {
                MessageBox.Show("sí existe paciente");
                consulta f3 = new consulta(txt_idpaciente.Text);
                f3.Show();
                this.Hide();
                c.Close();
            }
            else { MessageBox.Show("no existe paciente"); }
            }
            catch { }

        }

        private void nuevaconsulta_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
