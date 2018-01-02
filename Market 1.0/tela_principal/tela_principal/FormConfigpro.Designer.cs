namespace tela_principal
{
    partial class FormConfigpro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigpro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPesqPro = new System.Windows.Forms.TextBox();
            this.comPesqPro = new System.Windows.Forms.ComboBox();
            this.btnPesqPro = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.comCategoriaPro = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoPro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePro = new System.Windows.Forms.TextBox();
            this.btnExcluirPro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarPro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantPro = new System.Windows.Forms.TextBox();
            this.txtPreRevPro = new System.Windows.Forms.TextBox();
            this.txtPreForPro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFornecedorPro = new System.Windows.Forms.TextBox();
            this.LogoMarket = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPesquisa);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Location = new System.Drawing.Point(0, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 368);
            this.tabControl1.TabIndex = 21;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPesquisa.Controls.Add(this.btnVoltar);
            this.tabPesquisa.Controls.Add(this.dataGridView1);
            this.tabPesquisa.Controls.Add(this.txtPesqPro);
            this.tabPesquisa.Controls.Add(this.comPesqPro);
            this.tabPesquisa.Controls.Add(this.btnPesqPro);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(659, 342);
            this.tabPesquisa.TabIndex = 1;
            this.tabPesquisa.Text = "Pesquisa";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(572, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 302);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtPesqPro
            // 
            this.txtPesqPro.Location = new System.Drawing.Point(133, 8);
            this.txtPesqPro.Name = "txtPesqPro";
            this.txtPesqPro.Size = new System.Drawing.Size(171, 20);
            this.txtPesqPro.TabIndex = 7;
            this.txtPesqPro.TextChanged += new System.EventHandler(this.txtPesqPro_TextChanged);
            // 
            // comPesqPro
            // 
            this.comPesqPro.FormattingEnabled = true;
            this.comPesqPro.Items.AddRange(new object[] {
            "Todos",
            "Açougue",
            "Congelados",
            "Mercearia",
            "Bebidas",
            "Hortifruti",
            "Limpeza"});
            this.comPesqPro.Location = new System.Drawing.Point(6, 8);
            this.comPesqPro.Name = "comPesqPro";
            this.comPesqPro.Size = new System.Drawing.Size(121, 21);
            this.comPesqPro.TabIndex = 6;
            this.comPesqPro.Text = "Selecione";
            this.comPesqPro.SelectedIndexChanged += new System.EventHandler(this.comPesqPro_SelectedIndexChanged);
            this.comPesqPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comPesqPro_KeyPress);
            // 
            // btnPesqPro
            // 
            this.btnPesqPro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesqPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesqPro.Location = new System.Drawing.Point(310, 6);
            this.btnPesqPro.Name = "btnPesqPro";
            this.btnPesqPro.Size = new System.Drawing.Size(75, 23);
            this.btnPesqPro.TabIndex = 8;
            this.btnPesqPro.Text = "Pesquisar";
            this.btnPesqPro.UseVisualStyleBackColor = false;
            this.btnPesqPro.Click += new System.EventHandler(this.btnPesqPro_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabConfig.Controls.Add(this.comCategoriaPro);
            this.tabConfig.Controls.Add(this.button2);
            this.tabConfig.Controls.Add(this.button1);
            this.tabConfig.Controls.Add(this.label7);
            this.tabConfig.Controls.Add(this.label4);
            this.tabConfig.Controls.Add(this.txtCodigoPro);
            this.tabConfig.Controls.Add(this.label3);
            this.tabConfig.Controls.Add(this.txtNomePro);
            this.tabConfig.Controls.Add(this.btnExcluirPro);
            this.tabConfig.Controls.Add(this.label1);
            this.tabConfig.Controls.Add(this.btnAlterarPro);
            this.tabConfig.Controls.Add(this.label2);
            this.tabConfig.Controls.Add(this.label6);
            this.tabConfig.Controls.Add(this.txtQuantPro);
            this.tabConfig.Controls.Add(this.txtPreRevPro);
            this.tabConfig.Controls.Add(this.txtPreForPro);
            this.tabConfig.Controls.Add(this.label5);
            this.tabConfig.Controls.Add(this.txtFornecedorPro);
            this.tabConfig.Controls.Add(this.LogoMarket);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(659, 342);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Configuração";
            // 
            // comCategoriaPro
            // 
            this.comCategoriaPro.Enabled = false;
            this.comCategoriaPro.Items.AddRange(new object[] {
            "Açougue",
            "Congelados",
            "Mercearia",
            "Bebidas",
            "Hortifruti",
            "Limpeza"});
            this.comCategoriaPro.Location = new System.Drawing.Point(327, 134);
            this.comCategoriaPro.Name = "comCategoriaPro";
            this.comCategoriaPro.Size = new System.Drawing.Size(151, 21);
            this.comCategoriaPro.TabIndex = 40;
            this.comCategoriaPro.Text = "Selecione";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(149, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 39;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(572, 6);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Preço Revenda:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(354, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quantidade:";
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Enabled = false;
            this.txtCodigoPro.Location = new System.Drawing.Point(190, 134);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.ReadOnly = true;
            this.txtCodigoPro.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoPro.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Código:";
            // 
            // txtNomePro
            // 
            this.txtNomePro.Enabled = false;
            this.txtNomePro.Location = new System.Drawing.Point(190, 161);
            this.txtNomePro.Name = "txtNomePro";
            this.txtNomePro.Size = new System.Drawing.Size(288, 20);
            this.txtNomePro.TabIndex = 24;
            // 
            // btnExcluirPro
            // 
            this.btnExcluirPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluirPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluirPro.Location = new System.Drawing.Point(425, 292);
            this.btnExcluirPro.Name = "btnExcluirPro";
            this.btnExcluirPro.Size = new System.Drawing.Size(95, 36);
            this.btnExcluirPro.TabIndex = 31;
            this.btnExcluirPro.Text = "Excluir";
            this.btnExcluirPro.UseVisualStyleBackColor = false;
            this.btnExcluirPro.Click += new System.EventHandler(this.btnExcluirPro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(146, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:";
            // 
            // btnAlterarPro
            // 
            this.btnAlterarPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAlterarPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlterarPro.Location = new System.Drawing.Point(282, 292);
            this.btnAlterarPro.Name = "btnAlterarPro";
            this.btnAlterarPro.Size = new System.Drawing.Size(101, 36);
            this.btnAlterarPro.TabIndex = 30;
            this.btnAlterarPro.Text = "Salvar";
            this.btnAlterarPro.UseVisualStyleBackColor = false;
            this.btnAlterarPro.Click += new System.EventHandler(this.btnAlterarPro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(266, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Preço Fornecedor:";
            // 
            // txtQuantPro
            // 
            this.txtQuantPro.Enabled = false;
            this.txtQuantPro.Location = new System.Drawing.Point(425, 188);
            this.txtQuantPro.Name = "txtQuantPro";
            this.txtQuantPro.Size = new System.Drawing.Size(53, 20);
            this.txtQuantPro.TabIndex = 29;
            this.txtQuantPro.TextChanged += new System.EventHandler(this.txtQuantPro_TextChanged);
            // 
            // txtPreRevPro
            // 
            this.txtPreRevPro.Enabled = false;
            this.txtPreRevPro.Location = new System.Drawing.Point(380, 214);
            this.txtPreRevPro.Name = "txtPreRevPro";
            this.txtPreRevPro.Size = new System.Drawing.Size(98, 20);
            this.txtPreRevPro.TabIndex = 28;
            // 
            // txtPreForPro
            // 
            this.txtPreForPro.Enabled = false;
            this.txtPreForPro.Location = new System.Drawing.Point(190, 214);
            this.txtPreForPro.Name = "txtPreForPro";
            this.txtPreForPro.Size = new System.Drawing.Size(93, 20);
            this.txtPreForPro.TabIndex = 27;
            this.txtPreForPro.TextChanged += new System.EventHandler(this.txtPreForPro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fornecedor:";
            // 
            // txtFornecedorPro
            // 
            this.txtFornecedorPro.Enabled = false;
            this.txtFornecedorPro.Location = new System.Drawing.Point(190, 188);
            this.txtFornecedorPro.Name = "txtFornecedorPro";
            this.txtFornecedorPro.Size = new System.Drawing.Size(158, 20);
            this.txtFornecedorPro.TabIndex = 26;
            // 
            // LogoMarket
            // 
            this.LogoMarket.Image = ((System.Drawing.Image)(resources.GetObject("LogoMarket.Image")));
            this.LogoMarket.Location = new System.Drawing.Point(251, 18);
            this.LogoMarket.Name = "LogoMarket";
            this.LogoMarket.Size = new System.Drawing.Size(152, 78);
            this.LogoMarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoMarket.TabIndex = 38;
            this.LogoMarket.TabStop = false;
            // 
            // FormConfigpro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "FormConfigpro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de Produtos";
            this.Load += new System.EventHandler(this.FormConfigpro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPesqPro;
        private System.Windows.Forms.ComboBox comPesqPro;
        private System.Windows.Forms.Button btnPesqPro;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TextBox txtNomePro;
        private System.Windows.Forms.Button btnExcluirPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantPro;
        private System.Windows.Forms.TextBox txtPreRevPro;
        private System.Windows.Forms.TextBox txtPreForPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFornecedorPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoPro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox LogoMarket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comCategoriaPro;
    }
}