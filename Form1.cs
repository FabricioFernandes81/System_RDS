using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_RDS
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        void carregarPreferencias()
        {
            WriteRegistro LerRegistros = new WriteRegistro();
        

            ServerTemperatura temp = new ServerTemperatura((int)LerRegistros.Server, LerRegistros.Cidade,LerRegistros.Estado,LerRegistros.SelectTimer, LerRegistros.FolderPlayList, LerRegistros.FolderZara, LerRegistros.AtvPlaylist, LerRegistros.AtvZara,LerRegistros.Woeid);
            lblTemperatura.Text = string.Format("{0:0}", temp.Temperatura) + "ºC";
            lblCondicao.Text = temp.Condicao.ToString().ToUpper();
            lblHumidade.Text = string.Format("{0:0}", temp.Humidade.ToString()) + "%";
            picTempo.Image = temp.IconeTemp();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
               carregarPreferencias();
           
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Função de verificação de Atualizações
            SoftUpdate softUpdate = new SoftUpdate();
            //Carrega Dados 
            carregarPreferencias();
        }

       
    }
}
