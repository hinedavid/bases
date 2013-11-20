using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


     public  class Conexion
    {
        private  static string user = "q";
        private  static string clave;

        public Conexion()
        {}

        public Conexion(string u, string p) {

            user = u;
            clave = p;
        }
        
         public static string get_user(){

             return user;
         }
        

        
    }

