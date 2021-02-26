namespace DesafioPOO2
{
    partial class Especial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnElegir = new System.Windows.Forms.Button();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbGalones = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.Galones = new System.Windows.Forms.GroupBox();
            this.panelpagargalones = new System.Windows.Forms.Panel();
            this.txtdinerogalonesespecial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelgalones = new System.Windows.Forms.Panel();
            this.btnIrGalonesDiesel = new System.Windows.Forms.Button();
            this.txtgalonesespecial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Efectivo = new System.Windows.Forms.GroupBox();
            this.panelpagarefectivo = new System.Windows.Forms.Panel();
            this.txtdinero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelefectivo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtgalonesrecibidosdiesel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIrGalonesEfectivo = new System.Windows.Forms.Button();
            this.Txtefectivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Galones.SuspendLayout();
            this.panelpagargalones.SuspendLayout();
            this.panelgalones.SuspendLayout();
            this.Efectivo.SuspendLayout();
            this.panelpagarefectivo.SuspendLayout();
            this.panelefectivo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESPECIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliga como quiere retirar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnElegir);
            this.groupBox1.Controls.Add(this.rbEfectivo);
            this.groupBox1.Controls.Add(this.rbGalones);
            this.groupBox1.Location = new System.Drawing.Point(245, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galones o Efectivo.";
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(231, 57);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 2;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(102, 85);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo.TabIndex = 1;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbGalones
            // 
            this.rbGalones.AutoSize = true;
            this.rbGalones.Location = new System.Drawing.Point(102, 35);
            this.rbGalones.Name = "rbGalones";
            this.rbGalones.Size = new System.Drawing.Size(64, 17);
            this.rbGalones.TabIndex = 0;
            this.rbGalones.TabStop = true;
            this.rbGalones.Text = "Galones";
            this.rbGalones.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAtras.Location = new System.Drawing.Point(702, 718);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Galones
            // 
            this.Galones.Controls.Add(this.panelpagargalones);
            this.Galones.Controls.Add(this.panelgalones);
            this.Galones.Location = new System.Drawing.Point(70, 288);
            this.Galones.Name = "Galones";
            this.Galones.Size = new System.Drawing.Size(317, 303);
            this.Galones.TabIndex = 15;
            this.Galones.TabStop = false;
            this.Galones.Text = "Galones";
            // 
            // panelpagargalones
            // 
            this.panelpagargalones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelpagargalones.Controls.Add(this.txtdinerogalonesespecial);
            this.panelpagargalones.Controls.Add(this.label6);
            this.panelpagargalones.Controls.Add(this.label5);
            this.panelpagargalones.Location = new System.Drawing.Point(104, 201);
            this.panelpagargalones.Name = "panelpagargalones";
            this.panelpagargalones.Size = new System.Drawing.Size(135, 80);
            this.panelpagargalones.TabIndex = 3;
            this.panelpagargalones.Visible = false;
            // 
            // txtdinerogalonesespecial
            // 
            this.txtdinerogalonesespecial.Enabled = false;
            this.txtdinerogalonesespecial.Location = new System.Drawing.Point(36, 42);
            this.txtdinerogalonesespecial.Name = "txtdinerogalonesespecial";
            this.txtdinerogalonesespecial.Size = new System.Drawing.Size(78, 20);
            this.txtdinerogalonesespecial.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Su total a pagar es:";
            // 
            // panelgalones
            // 
            this.panelgalones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelgalones.Controls.Add(this.btnIrGalonesDiesel);
            this.panelgalones.Controls.Add(this.txtgalonesespecial);
            this.panelgalones.Controls.Add(this.label3);
            this.panelgalones.Location = new System.Drawing.Point(62, 31);
            this.panelgalones.Name = "panelgalones";
            this.panelgalones.Size = new System.Drawing.Size(200, 138);
            this.panelgalones.TabIndex = 2;
            this.panelgalones.Visible = false;
            // 
            // btnIrGalonesDiesel
            // 
            this.btnIrGalonesDiesel.Location = new System.Drawing.Point(79, 103);
            this.btnIrGalonesDiesel.Name = "btnIrGalonesDiesel";
            this.btnIrGalonesDiesel.Size = new System.Drawing.Size(50, 23);
            this.btnIrGalonesDiesel.TabIndex = 2;
            this.btnIrGalonesDiesel.Text = "Ir";
            this.btnIrGalonesDiesel.UseVisualStyleBackColor = true;
            this.btnIrGalonesDiesel.Click += new System.EventHandler(this.btnIrGalonesDiesel_Click);
            // 
            // txtgalonesespecial
            // 
            this.txtgalonesespecial.Location = new System.Drawing.Point(30, 54);
            this.txtgalonesespecial.Name = "txtgalonesespecial";
            this.txtgalonesespecial.Size = new System.Drawing.Size(147, 20);
            this.txtgalonesespecial.TabIndex = 1;
            this.txtgalonesespecial.TextChanged += new System.EventHandler(this.txtgalonesespecial_TextChanged);
            this.txtgalonesespecial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgalonesespecial_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero de galones:";
            // 
            // Efectivo
            // 
            this.Efectivo.Controls.Add(this.panelpagarefectivo);
            this.Efectivo.Controls.Add(this.panelefectivo);
            this.Efectivo.Location = new System.Drawing.Point(434, 288);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Size = new System.Drawing.Size(309, 398);
            this.Efectivo.TabIndex = 15;
            this.Efectivo.TabStop = false;
            this.Efectivo.Text = "Efectivo";
            // 
            // panelpagarefectivo
            // 
            this.panelpagarefectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelpagarefectivo.Controls.Add(this.txtdinero);
            this.panelpagarefectivo.Controls.Add(this.label8);
            this.panelpagarefectivo.Controls.Add(this.label7);
            this.panelpagarefectivo.Location = new System.Drawing.Point(87, 271);
            this.panelpagarefectivo.Name = "panelpagarefectivo";
            this.panelpagarefectivo.Size = new System.Drawing.Size(161, 80);
            this.panelpagarefectivo.TabIndex = 4;
            this.panelpagarefectivo.Visible = false;
            // 
            // txtdinero
            // 
            this.txtdinero.Enabled = false;
            this.txtdinero.Location = new System.Drawing.Point(43, 45);
            this.txtdinero.Name = "txtdinero";
            this.txtdinero.Size = new System.Drawing.Size(79, 20);
            this.txtdinero.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Su total a pagar es:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "$";
            // 
            // panelefectivo
            // 
            this.panelefectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelefectivo.Controls.Add(this.panel2);
            this.panelefectivo.Controls.Add(this.btnIrGalonesEfectivo);
            this.panelefectivo.Controls.Add(this.Txtefectivo);
            this.panelefectivo.Controls.Add(this.label4);
            this.panelefectivo.Location = new System.Drawing.Point(64, 31);
            this.panelefectivo.Name = "panelefectivo";
            this.panelefectivo.Size = new System.Drawing.Size(200, 219);
            this.panelefectivo.TabIndex = 3;
            this.panelefectivo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtgalonesrecibidosdiesel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(14, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 98);
            this.panel2.TabIndex = 14;
            // 
            // txtgalonesrecibidosdiesel
            // 
            this.txtgalonesrecibidosdiesel.Enabled = false;
            this.txtgalonesrecibidosdiesel.Location = new System.Drawing.Point(32, 46);
            this.txtgalonesrecibidosdiesel.Name = "txtgalonesrecibidosdiesel";
            this.txtgalonesrecibidosdiesel.Size = new System.Drawing.Size(100, 20);
            this.txtgalonesrecibidosdiesel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Los galones recibidos son:";
            // 
            // btnIrGalonesEfectivo
            // 
            this.btnIrGalonesEfectivo.Location = new System.Drawing.Point(67, 73);
            this.btnIrGalonesEfectivo.Name = "btnIrGalonesEfectivo";
            this.btnIrGalonesEfectivo.Size = new System.Drawing.Size(50, 23);
            this.btnIrGalonesEfectivo.TabIndex = 13;
            this.btnIrGalonesEfectivo.Text = "Ir";
            this.btnIrGalonesEfectivo.UseVisualStyleBackColor = true;
            this.btnIrGalonesEfectivo.Click += new System.EventHandler(this.btnIrGalonesEfectivo_Click_1);
            // 
            // Txtefectivo
            // 
            this.Txtefectivo.Location = new System.Drawing.Point(22, 41);
            this.Txtefectivo.Name = "Txtefectivo";
            this.Txtefectivo.Size = new System.Drawing.Size(149, 20);
            this.Txtefectivo.TabIndex = 1;
            this.Txtefectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtefectivo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Efectivo:";
            // 
            // Especial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(136)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.Efectivo);
            this.Controls.Add(this.Galones);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Especial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Especial_FormClosed);
            this.Load += new System.EventHandler(this.Especial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Galones.ResumeLayout(false);
            this.panelpagargalones.ResumeLayout(false);
            this.panelpagargalones.PerformLayout();
            this.panelgalones.ResumeLayout(false);
            this.panelgalones.PerformLayout();
            this.Efectivo.ResumeLayout(false);
            this.panelpagarefectivo.ResumeLayout(false);
            this.panelpagarefectivo.PerformLayout();
            this.panelefectivo.ResumeLayout(false);
            this.panelefectivo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbGalones;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox Galones;
        private System.Windows.Forms.Panel panelpagargalones;
        private System.Windows.Forms.TextBox txtdinerogalonesespecial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelgalones;
        private System.Windows.Forms.Button btnIrGalonesDiesel;
        private System.Windows.Forms.TextBox txtgalonesespecial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Efectivo;
        private System.Windows.Forms.Panel panelpagarefectivo;
        private System.Windows.Forms.TextBox txtdinero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelefectivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtgalonesrecibidosdiesel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIrGalonesEfectivo;
        private System.Windows.Forms.TextBox Txtefectivo;
        private System.Windows.Forms.Label label4;
    }
}