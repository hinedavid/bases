using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {


        nuevaconsulta snc = new nuevaconsulta();
        public Form1()
        {
            
            
            
            InitializeComponent();
            
            this.label2.Text = Conexion.get_user();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
      
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn_nueva_consulta_Click(object sender, EventArgs e)
        {
            snc.Show();
            this.Hide();
           // Conexion c = new ();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
