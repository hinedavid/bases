namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_nueva_consulta = new System.Windows.Forms.Button();
            this.btn_auditar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nueva_consulta
            // 
            this.btn_nueva_consulta.Location = new System.Drawing.Point(33, 45);
            this.btn_nueva_consulta.Name = "btn_nueva_consulta";
            this.btn_nueva_consulta.Size = new System.Drawing.Size(101, 46);
            this.btn_nueva_consulta.TabIndex = 0;
            this.btn_nueva_consulta.Text = "Nueva Consulta";
            this.btn_nueva_consulta.UseVisualStyleBackColor = true;
            this.btn_nueva_consulta.Click += new System.EventHandler(this.btn_nueva_consulta_Click);
            // 
            // btn_auditar
            // 
            this.btn_auditar.Location = new System.Drawing.Point(382, 45);
            this.btn_auditar.Name = "btn_auditar";
            this.btn_auditar.Size = new System.Drawing.Size(95, 46);
            this.btn_auditar.TabIndex = 2;
            this.btn_auditar.Text = "Auditar Consulta";
            this.btn_auditar.UseVisualStyleBackColor = true;
            this.btn_auditar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tratamientos por Paciente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Consultar Subordinados";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(382, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Agregar Médico";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(86, 13);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(0, 13);
            this.label_user.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aumento de salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_auditar);
            this.Controls.Add(this.btn_nueva_consulta);
            this.Controls.Add(this.button6);
            this.Name = "Form1";
            this.Text = "EDUS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nueva_consulta;
        private System.Windows.Forms.Button btn_auditar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}

