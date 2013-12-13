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
            string insertar = "Insert into edusdb.medico (identificacion,tipo_idenficacion,codigo_medico,nombre_medico,horario_medico,codigo_medico_supervisor,tipo_categoria,salario) values('" + txt_id.Text + "','" + txt_tipoid.Text + "','" + txt_codicoM.Text + "','" + txt_nombre.Text + "','" + txt_horario.Text + "','" + txt_codsup.Text + "','" + txt_tipo.Text + "','"+ "700"+ "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
