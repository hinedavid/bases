namespace WindowsFormsApplication1
{
    partial class Examenes
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.check_rx = new System.Windows.Forms.CheckBox();
            this.check_hemograma = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.check_heces = new System.Windows.Forms.CheckBox();
            this.check_renal = new System.Windows.Forms.CheckBox();
            this.check_lipidos = new System.Windows.Forms.CheckBox();
            this.check_hepatico = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(50, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 125);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // check_rx
            // 
            this.check_rx.AutoSize = true;
            this.check_rx.Location = new System.Drawing.Point(50, 203);
            this.check_rx.Name = "check_rx";
            this.check_rx.Size = new System.Drawing.Size(39, 17);
            this.check_rx.TabIndex = 1;
            this.check_rx.Text = "Rx";
            this.check_rx.UseVisualStyleBackColor = true;
            this.check_rx.CheckedChanged += new System.EventHandler(this.check_rx_CheckedChanged);
            // 
            // check_hemograma
            // 
            this.check_hemograma.AutoSize = true;
            this.check_hemograma.Location = new System.Drawing.Point(140, 203);
            this.check_hemograma.Name = "check_hemograma";
            this.check_hemograma.Size = new System.Drawing.Size(130, 17);
            this.check_hemograma.TabIndex = 2;
            this.check_hemograma.Text = "Hemograma Completo";
            this.check_hemograma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(276, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Urinálisis Completo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // check_heces
            // 
            this.check_heces.AutoSize = true;
            this.check_heces.Location = new System.Drawing.Point(405, 203);
            this.check_heces.Name = "check_heces";
            this.check_heces.Size = new System.Drawing.Size(116, 17);
            this.check_heces.TabIndex = 5;
            this.check_heces.Text = "Heces por Parásito";
            this.check_heces.UseVisualStyleBackColor = true;
            // 
            // check_renal
            // 
            this.check_renal.AutoSize = true;
            this.check_renal.Location = new System.Drawing.Point(50, 242);
            this.check_renal.Name = "check_renal";
            this.check_renal.Size = new System.Drawing.Size(80, 17);
            this.check_renal.TabIndex = 6;
            this.check_renal.Text = "Perfil Renal";
            this.check_renal.UseVisualStyleBackColor = true;
            // 
            // check_lipidos
            // 
            this.check_lipidos.AutoSize = true;
            this.check_lipidos.Location = new System.Drawing.Point(276, 242);
            this.check_lipidos.Name = "check_lipidos";
            this.check_lipidos.Size = new System.Drawing.Size(88, 17);
            this.check_lipidos.TabIndex = 7;
            this.check_lipidos.Text = "Perfìl Lipìdico";
            this.check_lipidos.UseVisualStyleBackColor = true;
            // 
            // check_hepatico
            // 
            this.check_hepatico.AutoSize = true;
            this.check_hepatico.Location = new System.Drawing.Point(140, 242);
            this.check_hepatico.Name = "check_hepatico";
            this.check_hepatico.Size = new System.Drawing.Size(95, 17);
            this.check_hepatico.TabIndex = 8;
            this.check_hepatico.Text = "Perfil Hepático";
            this.check_hepatico.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(405, 242);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Perfil Triode";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(50, 288);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(143, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Panel Básico Metabólico";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(239, 317);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 11;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(321, 317);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Examenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 352);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.check_hepatico);
            this.Controls.Add(this.check_lipidos);
            this.Controls.Add(this.check_renal);
            this.Controls.Add(this.check_heces);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_hemograma);
            this.Controls.Add(this.check_rx);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Examenes";
            this.Text = "Exámenes";
            this.Load += new System.EventHandler(this.Examenes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox check_rx;
        private System.Windows.Forms.CheckBox check_hemograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox check_heces;
        private System.Windows.Forms.CheckBox check_renal;
        private System.Windows.Forms.CheckBox check_lipidos;
        private System.Windows.Forms.CheckBox check_hepatico;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}