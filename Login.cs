using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;



    public class Login
    {
        private static string user;
        private static string pass;
        private static bool success;
        private static string tipo;
        //private static OracleCommand cmd;

        public Login(string login_user,string login_pass)
        {
            user = login_user;
            pass = login_pass;           
            OracleCommand cmd = new OracleCommand();
            //Conexion c = new Conexion();
            cmd = Conexion.get_cmd();

            try
            {
                

                //intenta abrir la base de datos
                //conn.Open();
                //String query = "select * from userdatabase2013.USUARIO";
                //String query = "select usuario,passwd from edusdb.USUARIO Where usuario='" + user + "'And passwd='" + pass + "'";
                String query = "select usuario,passwd,tipo from edusdb.USUARIO Where usuario='" + @user + "'And passwd='" + @pass + "'";
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(@user, Oracle.DataAccess.Client.OracleDbType.NVarchar2, 9);
                cmd.Parameters[0].Value = user;
                cmd.Parameters.Add(@pass, Oracle.DataAccess.Client.OracleDbType.NVarchar2, 9);
                cmd.Parameters[1].Value = pass;


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
                if ((user == DR["usuario"].ToString()) && (pass == DR["passwd"].ToString()))
                {
                    tipo = DR["tipo"].ToString();
                    success = true;
                }
                else { MessageBox.Show("Usuario o Contraseña incorrecta no entro al if"); }

                //Nos acordamos de cerrar la conexión en el caso de que todavía esté abierta


                //conn.Close();

            }

            catch
            {
                // c = new Conexion();
                MessageBox.Show("Usuario o Contraseña incorrecta del catch");
            }

        }


        public static string get_user()
        {

            return user;
        }

        public static bool Success()
        {

            return success;
        }
        public static string tipoU()
        {

            return tipo;
        }
    }

