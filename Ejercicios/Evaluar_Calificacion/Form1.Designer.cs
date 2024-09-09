namespace Evaluar_Calificacion
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbMateria = new System.Windows.Forms.TextBox();
            this.Tbcalificacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LbEvaluacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMA QUE EVALUA LA NOTA DE UN ESTUDIANTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificacion:";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(141, 59);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(384, 26);
            this.TbNombre.TabIndex = 4;
            this.TbNombre.TextChanged += new System.EventHandler(this.TbNombre_TextChanged);
            // 
            // TbMateria
            // 
            this.TbMateria.Location = new System.Drawing.Point(141, 106);
            this.TbMateria.Name = "TbMateria";
            this.TbMateria.Size = new System.Drawing.Size(384, 26);
            this.TbMateria.TabIndex = 5;
            this.TbMateria.TextChanged += new System.EventHandler(this.TbMateria_TextChanged);
            // 
            // Tbcalificacion
            // 
            this.Tbcalificacion.Location = new System.Drawing.Point(141, 146);
            this.Tbcalificacion.Name = "Tbcalificacion";
            this.Tbcalificacion.Size = new System.Drawing.Size(384, 26);
            this.Tbcalificacion.TabIndex = 6;
            this.Tbcalificacion.TextChanged += new System.EventHandler(this.Tbcalificacion_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "EVALUAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Se evalua al estudiante con:";
            // 
            // LbEvaluacion
            // 
            this.LbEvaluacion.AutoSize = true;
            this.LbEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEvaluacion.ForeColor = System.Drawing.Color.Red;
            this.LbEvaluacion.Location = new System.Drawing.Point(268, 293);
            this.LbEvaluacion.Name = "LbEvaluacion";
            this.LbEvaluacion.Size = new System.Drawing.Size(0, 32);
            this.LbEvaluacion.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.LbEvaluacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tbcalificacion);
            this.Controls.Add(this.TbMateria);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbMateria;
        private System.Windows.Forms.TextBox Tbcalificacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbEvaluacion;
    }
}

