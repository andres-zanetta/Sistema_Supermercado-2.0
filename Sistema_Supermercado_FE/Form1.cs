using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Sistema_Supermercado_BE;



namespace Sistema_Supermercado_FE
{
    public partial class Form1 : Form
    {
        Cliente myUsuario = new Cliente();
        int valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorNombre.SetError(textBox1, "Porfavor ingrese un nommbre válido");
                textBox1.Focus();
                return;
            }
            errorNombre.SetError(textBox1, "");


            if (textBox2.Text == "")
            {
                errorApellido.SetError(textBox2, "Porfavor ingrese un apellido válido");
                textBox2.Focus();
                return;
            }
            errorApellido.SetError(textBox2, "");


            if (textBox3.Text == "")
            {
                errorDNI.SetError(textBox3, "Porfavor igrese un DNI válido");
                textBox3.Focus();
                return;
            }
            errorDNI.SetError(textBox3, "");

            Form2 Formulario2 = new Form2();
            this.Hide();
            Formulario2.Show();

        }

  
       

        }
    }

