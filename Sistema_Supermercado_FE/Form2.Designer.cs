namespace Sistema_Supermercado_FE
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblNombMerc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMetDPago = new System.Windows.Forms.Label();
            this.textBoxNombMerc = new System.Windows.Forms.TextBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.errorCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 390);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(161, 48);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "CARGAR AL CARRITO";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblNombMerc
            // 
            this.lblNombMerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombMerc.Location = new System.Drawing.Point(449, 92);
            this.lblNombMerc.Name = "lblNombMerc";
            this.lblNombMerc.Size = new System.Drawing.Size(260, 22);
            this.lblNombMerc.TabIndex = 2;
            this.lblNombMerc.Text = "NOMBRE DE LA MERCADERIA";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(449, 164);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 25);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblMetDPago
            // 
            this.lblMetDPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMetDPago.Location = new System.Drawing.Point(450, 238);
            this.lblMetDPago.Name = "lblMetDPago";
            this.lblMetDPago.Size = new System.Drawing.Size(162, 21);
            this.lblMetDPago.TabIndex = 4;
            this.lblMetDPago.Text = "MÉTODO DE PAGO";
            // 
            // textBoxNombMerc
            // 
            this.textBoxNombMerc.Location = new System.Drawing.Point(708, 92);
            this.textBoxNombMerc.Name = "textBoxNombMerc";
            this.textBoxNombMerc.Size = new System.Drawing.Size(110, 20);
            this.textBoxNombMerc.TabIndex = 5;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(708, 164);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(110, 20);
            this.textBoxCod.TabIndex = 6;
            // 
            // errorCodigo
            // 
            this.errorCodigo.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Tarjeta de Debito",
            "Tarjeta de Credito"});
            this.comboBox1.Location = new System.Drawing.Point(708, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.textBoxNombMerc);
            this.Controls.Add(this.lblMetDPago);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombMerc);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "FE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblNombMerc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMetDPago;
        private System.Windows.Forms.TextBox textBoxNombMerc;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label lblMostrar1;
        private System.Windows.Forms.Label lblMostrar2;
        private System.Windows.Forms.Label lblMostrar3;
        private System.Windows.Forms.ErrorProvider errorCodigo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}