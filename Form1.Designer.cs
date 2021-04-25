
namespace System_RDS
{
    partial class FormPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.btConfig = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHumidade = new System.Windows.Forms.Label();
            this.lblCondicao = new System.Windows.Forms.Label();
            this.picTempo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(684, 28);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(104, 34);
            this.btConfig.TabIndex = 1;
            this.btConfig.Text = "Configurações";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(137, 16);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(95, 37);
            this.lblTemperatura.TabIndex = 2;
            this.lblTemperatura.Text = "30";
            this.lblTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHumidade);
            this.groupBox1.Controls.Add(this.lblCondicao);
            this.groupBox1.Controls.Add(this.picTempo);
            this.groupBox1.Controls.Add(this.lblTemperatura);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblHumidade
            // 
            this.lblHumidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidade.Location = new System.Drawing.Point(140, 53);
            this.lblHumidade.Name = "lblHumidade";
            this.lblHumidade.Size = new System.Drawing.Size(92, 19);
            this.lblHumidade.TabIndex = 4;
            this.lblHumidade.Text = "label2";
            this.lblHumidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCondicao
            // 
            this.lblCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicao.Location = new System.Drawing.Point(6, 94);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(138, 23);
            this.lblCondicao.TabIndex = 4;
            this.lblCondicao.Text = "label1";
            this.lblCondicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTempo
            // 
            this.picTempo.Image = global::System_RDS.Properties.Resources._11n;
            this.picTempo.Location = new System.Drawing.Point(6, 19);
            this.picTempo.Name = "picTempo";
            this.picTempo.Size = new System.Drawing.Size(128, 72);
            this.picTempo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTempo.TabIndex = 4;
            this.picTempo.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.button1);
            this.Name = "FormPrincipal";
            this.Text = "System Radio";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTempo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCondicao;
        private System.Windows.Forms.PictureBox picTempo;
        private System.Windows.Forms.Label lblHumidade;
    }
}

