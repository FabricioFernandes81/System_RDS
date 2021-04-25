
namespace System_RDS
{
    partial class FormConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTempo = new System.Windows.Forms.ComboBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.cobServidor = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.chkPlaylist = new System.Windows.Forms.CheckBox();
            this.chkZara = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderPlaylist = new System.Windows.Forms.TextBox();
            this.txtFolderZara = new System.Windows.Forms.TextBox();
            this.btZara = new System.Windows.Forms.Button();
            this.btDiretorioPlaylist = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDiretorioPlaylist);
            this.groupBox1.Controls.Add(this.btZara);
            this.groupBox1.Controls.Add(this.txtFolderZara);
            this.groupBox1.Controls.Add(this.txtFolderPlaylist);
            this.groupBox1.Controls.Add(this.chkZara);
            this.groupBox1.Controls.Add(this.chkPlaylist);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTempo);
            this.groupBox1.Controls.Add(this.txtUf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.lblServidor);
            this.groupBox1.Controls.Add(this.cobServidor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tempo de Sincronização:";
            // 
            // cboTempo
            // 
            this.cboTempo.FormattingEnabled = true;
            this.cboTempo.Items.AddRange(new object[] {
            "1 min",
            "5 min",
            "10 min",
            "15 min",
            "20 min",
            "25 min",
            "30 min"});
            this.cboTempo.Location = new System.Drawing.Point(211, 148);
            this.cboTempo.Name = "cboTempo";
            this.cboTempo.Size = new System.Drawing.Size(175, 21);
            this.cboTempo.TabIndex = 10;
            // 
            // txtUf
            // 
            this.txtUf.BackColor = System.Drawing.SystemColors.Window;
            this.txtUf.Enabled = false;
            this.txtUf.Location = new System.Drawing.Point(289, 88);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(42, 20);
            this.txtUf.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(12, 88);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(271, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(9, 72);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(12, 43);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(134, 20);
            this.txtCep.TabIndex = 3;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave_1);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(9, 27);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(85, 13);
            this.lblCep.TabIndex = 2;
            this.lblCep.Text = "CEP (99999999)";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(9, 132);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(128, 13);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Sincronizar Temperatura: ";
            // 
            // cobServidor
            // 
            this.cobServidor.FormattingEnabled = true;
            this.cobServidor.Location = new System.Drawing.Point(9, 148);
            this.cobServidor.Name = "cobServidor";
            this.cobServidor.Size = new System.Drawing.Size(179, 21);
            this.cobServidor.TabIndex = 0;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(413, 252);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(127, 23);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // chkPlaylist
            // 
            this.chkPlaylist.AutoSize = true;
            this.chkPlaylist.Location = new System.Drawing.Point(12, 186);
            this.chkPlaylist.Name = "chkPlaylist";
            this.chkPlaylist.Size = new System.Drawing.Size(112, 17);
            this.chkPlaylist.TabIndex = 12;
            this.chkPlaylist.Text = "Ativar para Playlist";
            this.chkPlaylist.UseVisualStyleBackColor = true;
            // 
            // chkZara
            // 
            this.chkZara.AutoSize = true;
            this.chkZara.Location = new System.Drawing.Point(211, 186);
            this.chkZara.Name = "chkZara";
            this.chkZara.Size = new System.Drawing.Size(102, 17);
            this.chkZara.TabIndex = 13;
            this.chkZara.Text = "Ativar para Zara";
            this.chkZara.UseVisualStyleBackColor = true;
            // 
            // txtFolderPlaylist
            // 
            this.txtFolderPlaylist.Location = new System.Drawing.Point(12, 209);
            this.txtFolderPlaylist.Name = "txtFolderPlaylist";
            this.txtFolderPlaylist.Size = new System.Drawing.Size(176, 20);
            this.txtFolderPlaylist.TabIndex = 14;
            // 
            // txtFolderZara
            // 
            this.txtFolderZara.Location = new System.Drawing.Point(219, 208);
            this.txtFolderZara.Name = "txtFolderZara";
            this.txtFolderZara.Size = new System.Drawing.Size(176, 20);
            this.txtFolderZara.TabIndex = 15;
            // 
            // btZara
            // 
            this.btZara.Location = new System.Drawing.Point(398, 208);
            this.btZara.Name = "btZara";
            this.btZara.Size = new System.Drawing.Size(24, 20);
            this.btZara.TabIndex = 16;
            this.btZara.Text = "...";
            this.btZara.UseVisualStyleBackColor = true;
            this.btZara.Click += new System.EventHandler(this.btZara_Click);
            // 
            // btDiretorioPlaylist
            // 
            this.btDiretorioPlaylist.Location = new System.Drawing.Point(189, 209);
            this.btDiretorioPlaylist.Name = "btDiretorioPlaylist";
            this.btDiretorioPlaylist.Size = new System.Drawing.Size(24, 20);
            this.btDiretorioPlaylist.TabIndex = 17;
            this.btDiretorioPlaylist.Text = "...";
            this.btDiretorioPlaylist.UseVisualStyleBackColor = true;
            this.btDiretorioPlaylist.Click += new System.EventHandler(this.btDiretorioPlaylist_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 287);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConfig";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.ComboBox cobServidor;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTempo;
        private System.Windows.Forms.Button btDiretorioPlaylist;
        private System.Windows.Forms.Button btZara;
        private System.Windows.Forms.TextBox txtFolderZara;
        private System.Windows.Forms.TextBox txtFolderPlaylist;
        private System.Windows.Forms.CheckBox chkZara;
        private System.Windows.Forms.CheckBox chkPlaylist;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}