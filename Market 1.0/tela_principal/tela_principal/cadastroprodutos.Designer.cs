namespace tela_principal
{
    partial class FormCadastroPro

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPro));
            this.txtNomePro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantPro = new System.Windows.Forms.TextBox();
            this.comCategoriaPro = new System.Windows.Forms.ComboBox();
            this.btnAdicionarPro = new System.Windows.Forms.Button();
            this.btnLimparPro = new System.Windows.Forms.Button();
            this.btnVoltarPro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFornecedorPro = new System.Windows.Forms.TextBox();
            this.txtPreForPro = new System.Windows.Forms.TextBox();
            this.txtPreRevPro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LogoMarket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePro
            // 
            this.txtNomePro.Location = new System.Drawing.Point(112, 135);
            this.txtNomePro.Name = "txtNomePro";
            this.txtNomePro.Size = new System.Drawing.Size(308, 20);
            this.txtNomePro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(68, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(51, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preço Fornecedor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantidade:";
            // 
            // txtQuantPro
            // 
            this.txtQuantPro.Location = new System.Drawing.Point(375, 161);
            this.txtQuantPro.Name = "txtQuantPro";
            this.txtQuantPro.Size = new System.Drawing.Size(45, 20);
            this.txtQuantPro.TabIndex = 3;
            this.txtQuantPro.TextChanged += new System.EventHandler(this.txtQuantPro_TextChanged);
            this.txtQuantPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantPro_KeyPress);
            // 
            // comCategoriaPro
            // 
            this.comCategoriaPro.Items.AddRange(new object[] {
            "Açougue",
            "Congelados",
            "Mercearia",
            "Bebidas",
            "Hortifruti",
            "Limpeza"});
            this.comCategoriaPro.Location = new System.Drawing.Point(112, 161);
            this.comCategoriaPro.Name = "comCategoriaPro";
            this.comCategoriaPro.Size = new System.Drawing.Size(151, 21);
            this.comCategoriaPro.TabIndex = 2;
            this.comCategoriaPro.Text = "Selecione";
            this.comCategoriaPro.SelectedIndexChanged += new System.EventHandler(this.comCategoriaPro_SelectedIndexChanged);
            this.comCategoriaPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comCategoriaPro_KeyPress);
            // 
            // btnAdicionarPro
            // 
            this.btnAdicionarPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdicionarPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarPro.Location = new System.Drawing.Point(123, 263);
            this.btnAdicionarPro.Name = "btnAdicionarPro";
            this.btnAdicionarPro.Size = new System.Drawing.Size(101, 36);
            this.btnAdicionarPro.TabIndex = 7;
            this.btnAdicionarPro.Text = "Adicionar";
            this.btnAdicionarPro.UseVisualStyleBackColor = false;
            this.btnAdicionarPro.Click += new System.EventHandler(this.btnAdicionarPro_Click);
            // 
            // btnLimparPro
            // 
            this.btnLimparPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimparPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimparPro.Location = new System.Drawing.Point(325, 263);
            this.btnLimparPro.Name = "btnLimparPro";
            this.btnLimparPro.Size = new System.Drawing.Size(95, 36);
            this.btnLimparPro.TabIndex = 8;
            this.btnLimparPro.Text = "Limpar";
            this.btnLimparPro.UseVisualStyleBackColor = false;
            this.btnLimparPro.Click += new System.EventHandler(this.btnLimparPro_Click);
            // 
            // btnVoltarPro
            // 
            this.btnVoltarPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVoltarPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltarPro.Location = new System.Drawing.Point(428, 303);
            this.btnVoltarPro.Name = "btnVoltarPro";
            this.btnVoltarPro.Size = new System.Drawing.Size(61, 23);
            this.btnVoltarPro.TabIndex = 9;
            this.btnVoltarPro.Text = "Voltar";
            this.btnVoltarPro.UseVisualStyleBackColor = false;
            this.btnVoltarPro.Click += new System.EventHandler(this.btnVoltarPro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fornecedor:";
            // 
            // txtFornecedorPro
            // 
            this.txtFornecedorPro.Location = new System.Drawing.Point(112, 188);
            this.txtFornecedorPro.Name = "txtFornecedorPro";
            this.txtFornecedorPro.Size = new System.Drawing.Size(308, 20);
            this.txtFornecedorPro.TabIndex = 4;
            // 
            // txtPreForPro
            // 
            this.txtPreForPro.Location = new System.Drawing.Point(340, 214);
            this.txtPreForPro.Name = "txtPreForPro";
            this.txtPreForPro.Size = new System.Drawing.Size(80, 20);
            this.txtPreForPro.TabIndex = 6;
            this.txtPreForPro.Text = "00.00";
            this.txtPreForPro.TextChanged += new System.EventHandler(this.txtPreForPro_TextChanged);
            this.txtPreForPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreForPro_KeyPress);
            // 
            // txtPreRevPro
            // 
            this.txtPreRevPro.Location = new System.Drawing.Point(112, 214);
            this.txtPreRevPro.Name = "txtPreRevPro";
            this.txtPreRevPro.Size = new System.Drawing.Size(80, 20);
            this.txtPreRevPro.TabIndex = 5;
            this.txtPreRevPro.Text = "00.00";
            this.txtPreRevPro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPreRevPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreRevPro_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Preço Revenda:";
            // 
            // LogoMarket
            // 
            this.LogoMarket.Image = ((System.Drawing.Image)(resources.GetObject("LogoMarket.Image")));
            this.LogoMarket.Location = new System.Drawing.Point(165, 27);
            this.LogoMarket.Name = "LogoMarket";
            this.LogoMarket.Size = new System.Drawing.Size(152, 78);
            this.LogoMarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoMarket.TabIndex = 0;
            this.LogoMarket.TabStop = false;
            // 
            // FormCadastroPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 329);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPreRevPro);
            this.Controls.Add(this.txtPreForPro);
            this.Controls.Add(this.txtFornecedorPro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVoltarPro);
            this.Controls.Add(this.btnLimparPro);
            this.Controls.Add(this.btnAdicionarPro);
            this.Controls.Add(this.comCategoriaPro);
            this.Controls.Add(this.txtQuantPro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePro);
            this.Controls.Add(this.LogoMarket);
            this.Name = "FormCadastroPro";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormCadastroPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoMarket;
        private System.Windows.Forms.TextBox txtNomePro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantPro;
        private System.Windows.Forms.ComboBox comCategoriaPro;
        private System.Windows.Forms.Button btnAdicionarPro;
        private System.Windows.Forms.Button btnLimparPro;
        private System.Windows.Forms.Button btnVoltarPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFornecedorPro;
        private System.Windows.Forms.TextBox txtPreForPro;
        private System.Windows.Forms.TextBox txtPreRevPro;
        private System.Windows.Forms.Label label6;
    }
}
