using Clase_FORMS.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("BIENVENIDO :) A MI APP");








        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usr = textBox1.Text;
            string pwd = textBox2.Text;

            if (usr == null || pwd == null) {

                MessageBox.Show("NO SE PUEDE DEJAR ESPACIOS EN BLANCO");
            
            }
            else
            {


                if (usr.ToLower().Equals("admin") && pwd.ToLower().Equals("admin") || usr.ToUpper().Equals("admin") && pwd.ToUpper().Equals("admin"))
                {
                    FRM_REGISTRO registro = new FRM_REGISTRO();
                    registro.Show();
                   
                else
                {

                    
                    
                        MessageBox.Show("USUARIO Y CONTRASEÑA ERRONEOS");
                        textBox1.Clear();
                        textBox2.Clear();
                    




                }
            }




        }
    }
}
