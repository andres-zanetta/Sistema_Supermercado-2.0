namespace Sistema_Supermercado_FE
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
            this.components = new System.ComponentModel.Container();
            this.label1_bienvenidos = new System.Windows.Forms.Label();
            this.labelNOMBRE = new System.Windows.Forms.Label();
            this.labelAPELLIDO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTel = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_bienvenidos
            // 
            this.label1_bienvenidos.AutoEllipsis = true;
            this.label1_bienvenidos.BackColor = System.Drawing.Color.Chocolate;
            this.label1_bienvenidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1_bienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_bienvenidos.Location = new System.Drawing.Point(223, 9);
            this.label1_bienvenidos.Name = "label1_bienvenidos";
            this.label1_bienvenidos.Size = new System.Drawing.Size(277, 81);
            this.label1_bienvenidos.TabIndex = 0;
            this.label1_bienvenidos.Text = "BIENVENIDOS SUPERMERCADO ZANE´S";
            this.label1_bienvenidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1_bienvenidos.UseCompatibleTextRendering = true;
            // 
            // labelNOMBRE
            // 
            this.labelNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOMBRE.Location = new System.Drawing.Point(77, 145);
            this.labelNOMBRE.Name = "labelNOMBRE";
            this.labelNOMBRE.Size = new System.Drawing.Size(117, 16);
            this.labelNOMBRE.TabIndex = 1;
            this.labelNOMBRE.Text = "NOMBRE";
            // 
            // labelAPELLIDO
            // 
            this.labelAPELLIDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPELLIDO.Location = new System.Drawing.Point(77, 182);
            this.labelAPELLIDO.Name = "labelAPELLIDO";
            this.labelAPELLIDO.Size = new System.Drawing.Size(122, 16);
            this.labelAPELLIDO.TabIndex = 2;
            this.labelAPELLIDO.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "TELÉFONO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 260);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(277, 20);
            this.textBox4.TabIndex = 8;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(595, 283);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(95, 37);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellido
            // 
            this.errorApellido.ContainerControl = this;
            // 
            // errorDNI
            // 
            this.errorDNI.ContainerControl = this;
            // 
            // errorTel
            // 
            this.errorTel.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(734, 351);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAPELLIDO);
            this.Controls.Add(this.labelNOMBRE);
            this.Controls.Add(this.label1_bienvenidos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1_bienvenidos;
        private System.Windows.Forms.Label labelNOMBRE;
        private System.Windows.Forms.Label labelAPELLIDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellido;
        private System.Windows.Forms.ErrorProvider errorDNI;
        private System.Windows.Forms.ErrorProvider errorTel;
    }
}


