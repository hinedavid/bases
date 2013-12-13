namespace WindowsFormsApplication1
{
    partial class tratamento
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
            this.label_codigo_medico = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_codigo_medico = new System.Windows.Forms.Label();
            this.lbl_asegurado = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_codigo_medico
            // 
            this.label_codigo_medico.AutoSize = true;
            this.label_codigo_medico.Location = new System.Drawing.Point(66, 55);
            this.label_codigo_medico.Name = "label_codigo_medico";
            this.label_codigo_medico.Size = new System.Drawing.Size(81, 13);
            this.label_codigo_medico.TabIndex = 2;
            this.label_codigo_medico.Text = "Codigo Medico:";
            this.label_codigo_medico.Click += new System.EventHandler(this.label_cantidad_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(570, 425);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(489, 425);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número Asegurado:";
            // 
            // lbl_codigo_medico
            // 
            this.lbl_codigo_medico.AutoSize = true;
            this.lbl_codigo_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_medico.Location = new System.Drawing.Point(154, 55);
            this.lbl_codigo_medico.Name = "lbl_codigo_medico";
            this.lbl_codigo_medico.Size = new System.Drawing.Size(79, 13);
            this.lbl_codigo_medico.TabIndex = 11;
            this.lbl_codigo_medico.Text = "label_codigo";
            this.lbl_codigo_medico.Click += new System.EventHandler(this.lbl_codigo_medico_Click);
            // 
            // lbl_asegurado
            // 
            this.lbl_asegurado.AutoSize = true;
            this.lbl_asegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asegurado.Location = new System.Drawing.Point(400, 54);
            this.lbl_asegurado.Name = "lbl_asegurado";
            this.lbl_asegurado.Size = new System.Drawing.Size(41, 13);
            this.lbl_asegurado.TabIndex = 12;
            this.lbl_asegurado.Text = "label1";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(69, 96);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(576, 304);
            this.txt_descripcion.TabIndex = 13;
            this.txt_descripcion.Text = "";
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // tratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 492);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_asegurado);
            this.Controls.Add(this.lbl_codigo_medico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label_codigo_medico);
            this.Name = "tratamento";
            this.Text = "Tratamiento";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_codigo_medico;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_codigo_medico;
        private System.Windows.Forms.Label lbl_asegurado;
        private System.Windows.Forms.RichTextBox txt_descripcion;
    }
}