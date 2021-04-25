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
    public partial class FormConfig : Form
    {
        private string _Woeid1;
        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
           
            cobServidor.DataSource = Enum.GetNames(typeof(WriteRegistro.Servers));

    
        if (carregar_Registros() == false)
           carregar_Registros();
        }
        bool carregar_Registros()
        {
      
            try
            {
                WriteRegistro LerRegistros = new WriteRegistro();
                cobServidor.SelectedIndex = (int)LerRegistros.Server;
                 txtCep.Text = LerRegistros.StrCep.ToString();
                 txtCidade.Text = LerRegistros.Cidade.ToString();
                 txtUf.Text = LerRegistros.Estado.ToString();
                cboTempo.SelectedItem = LerRegistros.SelectTimer.ToString();
                chkPlaylist.Checked = LerRegistros.AtvPlaylist;
                chkZara.Checked = LerRegistros.AtvZara;
                txtFolderPlaylist.Text = LerRegistros.FolderPlayList;
                txtFolderZara.Text = LerRegistros.FolderZara;
                _Woeid1 = LerRegistros.Woeid;
                return true;

            }
            catch (ArgumentException)
            {
                return false;
            }
           
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
  
           WriteRegistro Salvar = new WriteRegistro((WriteRegistro.Servers)cobServidor.SelectedIndex, txtCidade.Text,txtUf.Text,txtCep.Text, cboTempo.SelectedItem.ToString(), chkPlaylist.Checked,
               chkZara.Checked,txtFolderPlaylist.Text,txtFolderZara.Text, _Woeid1);
            MessageBox.Show("O software de ser reiniciado para que as alterarções entre em vigor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void BuscarCEP(string cep)
        {
    
            BuscaCep endereco = new BuscaCep(cep);
            txtCidade.Text = endereco.Cidade.ToString();
            txtUf.Text = endereco.Estado.ToString();
            _Woeid1 = endereco.Woeid;

        }
       

      

        private void txtCep_Leave_1(object sender, EventArgs e)
        {
            BuscarCEP(txtCep.Text);
        }

        private void btDiretorioPlaylist_Click(object sender, EventArgs e)
        {
         if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
            {
                txtFolderPlaylist.Text = folderBrowserDialog1.SelectedPath;
            }   
        }

        private void btZara_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderZara.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
