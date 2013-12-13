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
    public partial class aumento : Form
    {
        public aumento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertar = "begin edusdb.salarioAumentar('" + txt_aumento.Text + "'); END;";
            Conexion.get_cmd().CommandText = insertar;
            Conexion.get_cmd().CommandType = CommandType.Text;

            try
            {
                Conexion.get_cmd().ExecuteNonQuery();
                MessageBox.Show("insertado correctamente en la tabla Medico");
            }

            catch
            {
                MessageBox.Show("No fue posible insertarlo");
            }
        }
    }
}
