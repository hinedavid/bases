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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)

        {
            
            //String de conexiòn
            String connString ="User id=system;Password=hine;Data Source=XE;";
            OracleConnection conn = new OracleConnection(connString);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            
            //manejo de excepciones
            try {
                //intenta abrir la base de datos
                conn.Open();
                //String query = "select * from userdatabase2013.USUARIO";
                String query = "select usuario,passwd from userdatabase2013.USUARIO Where usuario='" + txt_user.Text + "'And passwd='" + txt_password.Text +"'";
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
     
                 //****Ejecutamos la consulta mediante un DataReader de Oracle
                 OracleDataReader reader = cmd.ExecuteReader();
                 //***si se quiere en un dataset
                    //Al adaptador hay que pasarle el string SQL y la Conexión
                 OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                 DataSet set = new DataSet();
                 adapter.Fill(set, "usuario");  //llena el conjunto con la respuesta de la consulta
                 //this.dataGridView1.DataSource = set;
                // this.dataGridView1.DataMember = "usuario";
                 //this.dataGridView1.Refresh();
                 DataRow DR;
                 DR = set.Tables["usuario"].Rows[0];
                 if ((txt_user.Text == DR["usuario"].ToString()) && (txt_password.Text == DR["passwd"].ToString()))
                 {
                     Conexion c = new Conexion(DR["usuario"].ToString(), DR["passwd"].ToString());
                     Form1 F1 = new Form1();
                     
                     
        F1.Show();
        this.Hide();
       // Conexion c = new Conexion();
        
    }
    else {MessageBox.Show("Usuario o Contraseña incorrecta"); }

    //Nos acordamos de cerrar la conexión en el caso de que todavía esté abierta
    
    
    conn.Close();
            
            }

            catch {
                // c = new Conexion();
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.txt_password.Clear();
            this.txt_user.Clear();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
