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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
             

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Cantidad";
            dataGridView1.Columns[1].Name = "Medicamento";
            dataGridView1.Columns[2].Name = "Dosis";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*falta crear estructura temporar o recurar del grid para poder pasaro definitivamente a la base*/
            int cant = int.Parse(this.txt_cantidad.Text);  /*prueba, se necesita cntrolar excepciòn de nulls*/
            string medicamento = this.txt_medicamento.Text; /*prueba*/
            string dosis = this.txt_dosis.Text;  /*prueba*/


            string[] row = new string[] { cant.ToString(), medicamento, dosis };
            dataGridView1.Rows.Add(row);
            /*String Nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //Para obtener el nombre
            String Direccion = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //Para obtener la dirección
            String Telefono = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //Para obtener el telefóno*/

            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                String Nombre = Fila.Cells[0].Value.ToString(); //Para obtener el nombre

                MessageBox.Show(Fila.Cells[0].Value.ToString(),Fila.Cells[1].Value.ToString());
                
            }
        }
    }
}
