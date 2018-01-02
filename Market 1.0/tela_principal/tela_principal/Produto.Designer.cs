namespace tela_principal
{
    partial class Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.btnAdicionarPro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesqPro = new System.Windows.Forms.Button();
            this.LogoMarket = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarPro
            // 
            this.btnAdicionarPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdicionarPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarPro.Location = new System.Drawing.Point(101, 84);
            this.btnAdicionarPro.Name = "btnAdicionarPro";
            this.btnAdicionarPro.Size = new System.Drawing.Size(207, 23);
            this.btnAdicionarPro.TabIndex = 0;
            this.btnAdicionarPro.Text = "Cadastrar Produto";
            this.btnAdicionarPro.UseVisualStyleBackColor = false;
            this.btnAdicionarPro.Click += new System.EventHandler(this.btnAdicionarPro_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(314, 179);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesqPro
            // 
            this.btnPesqPro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPesqPro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesqPro.Location = new System.Drawing.Point(101, 113);
            this.btnPesqPro.Name = "btnPesqPro";
            this.btnPesqPro.Size = new System.Drawing.Size(207, 23);
            this.btnPesqPro.TabIndex = 2;
            this.btnPesqPro.Text = "Pesquisar Produtos";
            this.btnPesqPro.UseVisualStyleBackColor = false;
            this.btnPesqPro.Click += new System.EventHandler(this.btnPesqPro_Click);
            // 
            // LogoMarket
            // 
            this.LogoMarket.Image = ((System.Drawing.Image)(resources.GetObject("LogoMarket.Image")));
            this.LogoMarket.Location = new System.Drawing.Point(133, 11);
            this.LogoMarket.Name = "LogoMarket";
            this.LogoMarket.Size = new System.Drawing.Size(152, 67);
            this.LogoMarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoMarket.TabIndex = 17;
            this.LogoMarket.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(101, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Meu Carrinho";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 221);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogoMarket);
            this.Controls.Add(this.btnPesqPro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionarPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMarketPrincipal";
            this.Load += new System.EventHandler(this.FormMarketPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMarket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarPro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesqPro;
        private System.Windows.Forms.PictureBox LogoMarket;
        private System.Windows.Forms.Button button1;
    }
}