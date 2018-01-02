namespace tela_principal
{
    partial class FormPesqProCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesqProCli));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPesqPro = new System.Windows.Forms.TextBox();
            this.comPesqPro = new System.Windows.Forms.ComboBox();
            this.btnPesqPro = new System.Windows.Forms.Button();
            this.LogoMarket = new System.Windows.Forms.PictureBox();
            this.tabPesq = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabVisualizar = new System.Windows.Forms.TabPage();
            this.comCategoriaPro = new System.Windows.Forms.ComboBox();
            this.btnAdicionarCar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoPro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreRevPro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFornecedorPro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).BeginInit();
            this.tabPesq.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabVisualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(576, 64);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 270);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtPesqPro
            // 
            this.txtPesqPro.Location = new System.Drawing.Point(133, 66);
            this.txtPesqPro.Name = "txtPesqPro";
            this.txtPesqPro.Size = new System.Drawing.Size(152, 20);
            this.txtPesqPro.TabIndex = 12;
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
            this.comPesqPro.Location = new System.Drawing.Point(6, 66);
            this.comPesqPro.Name = "comPesqPro";
            this.comPesqPro.Size = new System.Drawing.Size(121, 21);
            this.comPesqPro.TabIndex = 11;
            this.comPesqPro.Text = "Selecione";
            // 
            // btnPesqPro
            // 
            this.btnPesqPro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesqPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesqPro.Location = new System.Drawing.Point(291, 64);
            this.btnPesqPro.Name = "btnPesqPro";
            this.btnPesqPro.Size = new System.Drawing.Size(75, 23);
            this.btnPesqPro.TabIndex = 13;
            this.btnPesqPro.Text = "Pesquisar";
            this.btnPesqPro.UseVisualStyleBackColor = false;
            this.btnPesqPro.Click += new System.EventHandler(this.btnPesqPro_Click);
            // 
            // LogoMarket
            // 
            this.LogoMarket.Image = ((System.Drawing.Image)(resources.GetObject("LogoMarket.Image")));
            this.LogoMarket.Location = new System.Drawing.Point(388, 10);
            this.LogoMarket.Name = "LogoMarket";
            this.LogoMarket.Size = new System.Drawing.Size(171, 77);
            this.LogoMarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoMarket.TabIndex = 15;
            this.LogoMarket.TabStop = false;
            // 
            // tabPesq
            // 
            this.tabPesq.Controls.Add(this.tabPage1);
            this.tabPesq.Controls.Add(this.tabVisualizar);
            this.tabPesq.Location = new System.Drawing.Point(2, 3);
            this.tabPesq.Name = "tabPesq";
            this.tabPesq.SelectedIndex = 0;
            this.tabPesq.Size = new System.Drawing.Size(667, 397);
            this.tabPesq.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.comPesqPro);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.LogoMarket);
            this.tabPage1.Controls.Add(this.txtPesqPro);
            this.tabPage1.Controls.Add(this.btnPesqPro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa";
            // 
            // tabVisualizar
            // 
            this.tabVisualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabVisualizar.Controls.Add(this.comCategoriaPro);
            this.tabVisualizar.Controls.Add(this.btnAdicionarCar);
            this.tabVisualizar.Controls.Add(this.button1);
            this.tabVisualizar.Controls.Add(this.label7);
            this.tabVisualizar.Controls.Add(this.txtCodigoPro);
            this.tabVisualizar.Controls.Add(this.label3);
            this.tabVisualizar.Controls.Add(this.txtNomePro);
            this.tabVisualizar.Controls.Add(this.label1);
            this.tabVisualizar.Controls.Add(this.label2);
            this.tabVisualizar.Controls.Add(this.txtPreRevPro);
            this.tabVisualizar.Controls.Add(this.label5);
            this.tabVisualizar.Controls.Add(this.txtFornecedorPro);
            this.tabVisualizar.Controls.Add(this.pictureBox1);
            this.tabVisualizar.Location = new System.Drawing.Point(4, 22);
            this.tabVisualizar.Name = "tabVisualizar";
            this.tabVisualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisualizar.Size = new System.Drawing.Size(659, 371);
            this.tabVisualizar.TabIndex = 1;
            this.tabVisualizar.Text = "Adicionar";
            this.tabVisualizar.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.comCategoriaPro.Location = new System.Drawing.Point(324, 153);
            this.comCategoriaPro.Name = "comCategoriaPro";
            this.comCategoriaPro.Size = new System.Drawing.Size(151, 21);
            this.comCategoriaPro.TabIndex = 59;
            this.comCategoriaPro.Text = "Selecione";
            // 
            // btnAdicionarCar
            // 
            this.btnAdicionarCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdicionarCar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarCar.Location = new System.Drawing.Point(275, 290);
            this.btnAdicionarCar.Name = "btnAdicionarCar";
            this.btnAdicionarCar.Size = new System.Drawing.Size(101, 36);
            this.btnAdicionarCar.TabIndex = 58;
            this.btnAdicionarCar.Text = "Adicionar ao carrinho";
            this.btnAdicionarCar.UseVisualStyleBackColor = false;
            this.btnAdicionarCar.Click += new System.EventHandler(this.btnAdicionarCar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(569, 25);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Preço:";
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Enabled = false;
            this.txtCodigoPro.Location = new System.Drawing.Point(187, 153);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoPro.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Código:";
            // 
            // txtNomePro
            // 
            this.txtNomePro.Location = new System.Drawing.Point(187, 180);
            this.txtNomePro.Name = "txtNomePro";
            this.txtNomePro.ReadOnly = true;
            this.txtNomePro.Size = new System.Drawing.Size(288, 20);
            this.txtNomePro.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(143, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(263, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Categoria:";
            // 
            // txtPreRevPro
            // 
            this.txtPreRevPro.Location = new System.Drawing.Point(395, 206);
            this.txtPreRevPro.Name = "txtPreRevPro";
            this.txtPreRevPro.ReadOnly = true;
            this.txtPreRevPro.Size = new System.Drawing.Size(80, 20);
            this.txtPreRevPro.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fornecedor:";
            // 
            // txtFornecedorPro
            // 
            this.txtFornecedorPro.Location = new System.Drawing.Point(187, 207);
            this.txtFornecedorPro.Name = "txtFornecedorPro";
            this.txtFornecedorPro.ReadOnly = true;
            this.txtFornecedorPro.Size = new System.Drawing.Size(158, 20);
            this.txtFornecedorPro.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(248, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // FormPesqProCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 400);
            this.Controls.Add(this.tabPesq);
            this.Name = "FormPesqProCli";
            this.Text = "Pesquisa de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPesqProCli_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).EndInit();
            this.tabPesq.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabVisualizar.ResumeLayout(false);
            this.tabVisualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPesqPro;
        private System.Windows.Forms.ComboBox comPesqPro;
        private System.Windows.Forms.Button btnPesqPro;
        private System.Windows.Forms.PictureBox LogoMarket;
        private System.Windows.Forms.TabControl tabPesq;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabVisualizar;
        private System.Windows.Forms.ComboBox comCategoriaPro;
        private System.Windows.Forms.Button btnAdicionarCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomePro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreRevPro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFornecedorPro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigoPro;
        private System.Windows.Forms.Label label3;
    }
}