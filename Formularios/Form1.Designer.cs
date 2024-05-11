namespace Clase_FORMS.Formularios
{
    partial class FRM_REGISTRO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Texbox_edad = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_fecha_ingreso = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Texbox_edad
            // 
            this.Texbox_edad.AutoSize = true;
            this.Texbox_edad.Location = new System.Drawing.Point(105, 43);
            this.Texbox_edad.Name = "Texbox_edad";
            this.Texbox_edad.Size = new System.Drawing.Size(106, 13);
            this.Texbox_edad.TabIndex = 0;
            this.Texbox_edad.Text = "INGRESE SU EDAD";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(128, 84);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre";
            this.label_nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label_fecha_ingreso
            // 
            this.label_fecha_ingreso.AutoSize = true;
            this.label_fecha_ingreso.Location = new System.Drawing.Point(128, 116);
            this.label_fecha_ingreso.Name = "label_fecha_ingreso";
            this.label_fecha_ingreso.Size = new System.Drawing.Size(75, 13);
            this.label_fecha_ingreso.TabIndex = 4;
            this.label_fecha_ingreso.Text = "Fecha Ingreso";
            this.label_fecha_ingreso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // FRM_REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_fecha_ingreso);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Texbox_edad);
            this.Name = "FRM_REGISTRO";
            this.Text = "FRM_REGISTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texbox_edad;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_fecha_ingreso;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}