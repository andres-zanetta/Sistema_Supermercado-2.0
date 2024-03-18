using Sistema_Supermercado_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Supermercado_FE
{
    public partial class Form2 : Form
    {
        Mercaderia myMercaderia = new Mercaderia();

        public DataTable ListaDT { get; set; } = new DataTable();

        public Mercaderias ListaMercaderias { get; set; } = new Mercaderias();

        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = ListaMercaderias.ListaDT;
        }



        private void btnCargar_Click(object sender, EventArgs e)
        {
            decimal Verificacion;
            if (!Decimal.TryParse(textBoxCod.Text, out Verificacion))

            {
                errorCodigo.SetError(textBoxCod, "Ingrese un dato numerico Entero");
                return;
            }

            else
            {
                errorCodigo.SetError(textBoxCod, "");

                MessageBox.Show("Merecaderia Cargada");

                

                Mercaderia mercaderia = new Mercaderia();
                mercaderia.Agregar(textBoxNombMerc.Text,
                                    textBoxCod.Text,
                                     comboBox1.Text);

              

                ListaMercaderias.InsertMercaderia(mercaderia);

                dataGridView1.DataSource = ListaMercaderias.ListaDT;


            }


        }

       
    }

}
