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
    public partial class AgregarMedico : Form
    {
        public AgregarMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //establece la conexión
            Conexion c = new Conexion();

            string insertar = "Insert into scott.medico (identificacion,tipo_id,codigo_medico,nombre_medico,horario_medico,id_medico_supervisor,tipo_id_supervisor,tipo_categoria,salario) values('" + txt_id.Text + "','" + comboBox1.SelectedItem + "','" + txt_codicoM.Text + "','" + txt_nombre.Text + "','" + cmb_horario.SelectedItem + "','" + txt_codsup.Text + "','" + Bx_tipo_id_sup.SelectedItem + "','" + txt_tipo.Text + "','"+ txt_salario.Text + "')";
            Conexion.get_cmd().CommandText = insertar;
            Conexion.get_cmd().CommandType = CommandType.Text;

            try
            {
                Conexion.get_cmd().ExecuteNonQuery();
                MessageBox.Show("insertado correctamente en la tabla Medico");
                c.Close();
            }

            catch
            {
                MessageBox.Show("No fue posible insertarlo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarMedico_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
