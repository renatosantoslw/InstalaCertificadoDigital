namespace CERT
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAcao = new System.Windows.Forms.Button();
            this.btnAcao2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictBoxLogoPainel = new System.Windows.Forms.PictureBox();
            this.lblPainel = new System.Windows.Forms.Label();
            this.pictBoxPainel = new System.Windows.Forms.PictureBox();
            this.txtCert = new System.Windows.Forms.TextBox();
            this.lblIncluir = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogoPainel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPainel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(533, 391);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(91, 23);
            this.btnAcao.TabIndex = 0;
            this.btnAcao.Text = "Abrir";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // btnAcao2
            // 
            this.btnAcao2.Location = new System.Drawing.Point(436, 391);
            this.btnAcao2.Name = "btnAcao2";
            this.btnAcao2.Size = new System.Drawing.Size(91, 23);
            this.btnAcao2.TabIndex = 2;
            this.btnAcao2.Text = "Salvar";
            this.btnAcao2.UseVisualStyleBackColor = true;
            this.btnAcao2.Click += new System.EventHandler(this.btnAcao2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Certificado String:";
            // 
            // pictBoxLogoPainel
            // 
            this.pictBoxLogoPainel.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxLogoPainel.Image")));
            this.pictBoxLogoPainel.Location = new System.Drawing.Point(12, 10);
            this.pictBoxLogoPainel.Margin = new System.Windows.Forms.Padding(2);
            this.pictBoxLogoPainel.Name = "pictBoxLogoPainel";
            this.pictBoxLogoPainel.Size = new System.Drawing.Size(48, 48);
            this.pictBoxLogoPainel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictBoxLogoPainel.TabIndex = 61;
            this.pictBoxLogoPainel.TabStop = false;
            // 
            // lblPainel
            // 
            this.lblPainel.AutoSize = true;
            this.lblPainel.BackColor = System.Drawing.Color.Transparent;
            this.lblPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPainel.ForeColor = System.Drawing.Color.White;
            this.lblPainel.Location = new System.Drawing.Point(71, 24);
            this.lblPainel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPainel.Name = "lblPainel";
            this.lblPainel.Size = new System.Drawing.Size(238, 24);
            this.lblPainel.TabIndex = 60;
            this.lblPainel.Text = "Instalador Certificado Digital";
            // 
            // pictBoxPainel
            // 
            this.pictBoxPainel.BackColor = System.Drawing.Color.SteelBlue;
            this.pictBoxPainel.Location = new System.Drawing.Point(-1, -1);
            this.pictBoxPainel.Margin = new System.Windows.Forms.Padding(2);
            this.pictBoxPainel.Name = "pictBoxPainel";
            this.pictBoxPainel.Size = new System.Drawing.Size(726, 70);
            this.pictBoxPainel.TabIndex = 59;
            this.pictBoxPainel.TabStop = false;
            // 
            // txtCert
            // 
            this.txtCert.BackColor = System.Drawing.SystemColors.Control;
            this.txtCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCert.Location = new System.Drawing.Point(23, 102);
            this.txtCert.Margin = new System.Windows.Forms.Padding(2);
            this.txtCert.Multiline = true;
            this.txtCert.Name = "txtCert";
            this.txtCert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCert.Size = new System.Drawing.Size(607, 213);
            this.txtCert.TabIndex = 63;
            // 
            // lblIncluir
            // 
            this.lblIncluir.AutoSize = true;
            this.lblIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblIncluir.LinkColor = System.Drawing.Color.SteelBlue;
            this.lblIncluir.Location = new System.Drawing.Point(580, 338);
            this.lblIncluir.Name = "lblIncluir";
            this.lblIncluir.Size = new System.Drawing.Size(47, 15);
            this.lblIncluir.TabIndex = 64;
            this.lblIncluir.TabStop = true;
            this.lblIncluir.Text = "Instalar";
            this.lblIncluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblIncluir_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(480, 338);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 15);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Converter PFX";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 375);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblIncluir);
            this.Controls.Add(this.txtCert);
            this.Controls.Add(this.pictBoxLogoPainel);
            this.Controls.Add(this.lblPainel);
            this.Controls.Add(this.pictBoxPainel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcao2);
            this.Controls.Add(this.btnAcao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CERT";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogoPainel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPainel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.Button btnAcao2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pictBoxLogoPainel;
        internal System.Windows.Forms.Label lblPainel;
        internal System.Windows.Forms.PictureBox pictBoxPainel;
        internal System.Windows.Forms.TextBox txtCert;
        internal System.Windows.Forms.LinkLabel lblIncluir;
        internal System.Windows.Forms.LinkLabel linkLabel1;
    }
}

