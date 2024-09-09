namespace suma
{
    partial class suma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNum1 = new System.Windows.Forms.TextBox();
            this.TbNum2 = new System.Windows.Forms.TextBox();
            this.BtmSumar = new System.Windows.Forms.Button();
            this.BtmSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TbNum1
            // 
            this.TbNum1.Location = new System.Drawing.Point(144, 39);
            this.TbNum1.Name = "TbNum1";
            this.TbNum1.Size = new System.Drawing.Size(100, 20);
            this.TbNum1.TabIndex = 2;
            this.TbNum1.TextChanged += new System.EventHandler(this.TbNum1_TextChanged);
            // 
            // TbNum2
            // 
            this.TbNum2.Location = new System.Drawing.Point(158, 109);
            this.TbNum2.Name = "TbNum2";
            this.TbNum2.Size = new System.Drawing.Size(100, 20);
            this.TbNum2.TabIndex = 3;
            this.TbNum2.TextChanged += new System.EventHandler(this.TbNum2_TextChanged);
            // 
            // BtmSumar
            // 
            this.BtmSumar.BackColor = System.Drawing.Color.OliveDrab;
            this.BtmSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmSumar.ForeColor = System.Drawing.Color.White;
            this.BtmSumar.Location = new System.Drawing.Point(177, 187);
            this.BtmSumar.Name = "BtmSumar";
            this.BtmSumar.Size = new System.Drawing.Size(106, 39);
            this.BtmSumar.TabIndex = 4;
            this.BtmSumar.Text = "Sumar";
            this.BtmSumar.UseVisualStyleBackColor = false;
            this.BtmSumar.Click += new System.EventHandler(this.BtmSumar_Click);
            // 
            // BtmSalir
            // 
            this.BtmSalir.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtmSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmSalir.ForeColor = System.Drawing.Color.White;
            this.BtmSalir.Location = new System.Drawing.Point(511, 251);
            this.BtmSalir.Name = "BtmSalir";
            this.BtmSalir.Size = new System.Drawing.Size(119, 31);
            this.BtmSalir.TabIndex = 5;
            this.BtmSalir.Text = "SALIR";
            this.BtmSalir.UseVisualStyleBackColor = false;
            this.BtmSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 294);
            this.Controls.Add(this.BtmSalir);
            this.Controls.Add(this.BtmSumar);
            this.Controls.Add(this.TbNum2);
            this.Controls.Add(this.TbNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "suma";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNum1;
        private System.Windows.Forms.TextBox TbNum2;
        private System.Windows.Forms.Button BtmSumar;
        private System.Windows.Forms.Button BtmSalir;
    }
}

