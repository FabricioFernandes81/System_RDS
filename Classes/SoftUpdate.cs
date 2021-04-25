using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Net.Http;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;

namespace System_RDS
{
    class SoftUpdate
    {
        private
        string _VersaoAtual;
      //  private DateTime StartTime;
        private string _Baixado;
        private int _Bar;
        //  bool _ShowDownload;
        public SoftUpdate()
        {

            //Verificar Versão do Executavel 

            Assembly assem = Assembly.GetEntryAssembly();
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            //Console.WriteLine("Application {0}, Version {1}", assemName.Name, ver.ToString());

            Rodar(ver.ToString());




        }

        public SoftUpdate(bool download)
        {
            //
            if (download !=false) DownloadUpdate();
        }
        private async void DownloadUpdate()
        {
            //Arquivo para teste 
            string arquivoExec = "https://github.com/nicehash/NiceHashMinerLegacy/releases/download/3.0.6.5/nhm_windows_3.0.6.5.exe";
            string pastaExec = @"C:\temp\";
        //    StartTime = DateTime.Now;
        
            using (var client = new WebClient())
            {
            client.DownloadProgressChanged += OndownloadProgressChanged;
            client.DownloadFileCompleted += OnDownloadFileCompleted;
            await client.DownloadFileTaskAsync(new Uri(arquivoExec), pastaExec + "setup.exe");
         
            }
        }
        private async void Rodar(string versao)
        {

            HttpClient cliente = new HttpClient();

            string resultado = await cliente.GetStringAsync("http://98fm.org.br/AppVersao.txt");

            _VersaoAtual = resultado;

            if (VerificarVersao(versao, _VersaoAtual) != true)
            //{
            //    Console.WriteLine("verção: " + versao);
            //    Console.WriteLine("Versao do Site: " + _VersaoAtual);
        
           // }
          //  else
            {
                string message = "Uma nova versão do " + _VersaoAtual +" está disponível, deseja Atualizar ?";
                string title = "Atualização online";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    
                       FormUpdate formUpdate = new FormUpdate();
                       formUpdate.Show();
                }
                 
             
            }





        }
        
        bool VerificarVersao(string ver, string ver1)
        {

            if (ver == ver1)
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }

        private  void OndownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _Bar = e.ProgressPercentage;
         //   var s = (DateTime.Now - StartTime).TotalSeconds;
         //   var sd = ReadableFilesize(e.BytesReceived / s);
         //  _Baixado = "download speed" + sd + "/ sec" + "downloaded" + ReadableFilesize(e.BytesReceived) + "/ Total" + ReadableFilesize(e.TotalBytesToReceive); // a label box, to display the current Download the data

        }
        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            
         Console.WriteLine("Download finished!");
         //Abre o Instalador
            System.Diagnostics.Process.Start(@"c:\temp\setup.exe");
         //Fechar o Form de Atualização
         FormUpdate update = new FormUpdate();
          update.Close();

        }

        private static string ReadableFilesize(double size)
        {
            String[] units = { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return Math.Round(size) + units[i];
        }

        public String Baixando
        {
            set { _Baixado = value; }
            get { return _Baixado; }
        }
        public int Bar
        {
            set { _Bar = value; }
            get { return _Bar; }
        }

    }

}
