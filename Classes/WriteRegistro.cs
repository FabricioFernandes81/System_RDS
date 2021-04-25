using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace System_RDS
{
    class WriteRegistro
    {
        public enum Servers { HgBrasil, OpenWeather }
        private
        const string userRoot = "HKEY_CURRENT_USER";
        const string subKey = "System RDS";
        const string keyName = userRoot + "\\" + subKey;

        private string _cidade, _Estado, _cep, _selectTimer,_folderPlaylist,_folderZara, _Woeid;
        private bool _AtPlaylist,_AtZara;
       // private string _tpApi;
        protected Servers _Servers;
        public WriteRegistro(Servers tpApi ,string cidade,string uf,string cep,string selecttimer,bool ativo,bool ativo1,string folderPl,string folderZr,string WoeidCi)
        {
          
            Registry.SetValue(keyName, "SelApi",tpApi);
            Registry.SetValue(keyName, "Cidade", cidade);
            Registry.SetValue(keyName, "UF", uf);
            Registry.SetValue(keyName, "Cep", cep);
            Registry.SetValue(keyName, "Timer", selecttimer);
            Registry.SetValue(keyName, "Playlist", ativo);
            Registry.SetValue(keyName, "FolderPl", folderPl);
            Registry.SetValue(keyName, "Zara", ativo1);
            Registry.SetValue(keyName, "FolderZr", folderZr);
            Registry.SetValue(keyName, "Woeid", WoeidCi); 

        }
        public WriteRegistro()
        {
            //string tc = ;
            Servers servidor = (Servers)Enum.Parse(typeof(Servers), (string)Registry.GetValue(keyName, "SelApi", null));
            _Servers = servidor;

            _cidade = (string)Registry.GetValue(keyName, "Cidade", null);
            _Estado = (string)Registry.GetValue(keyName, "UF", null);
            _cep = (string)Registry.GetValue(keyName, "Cep", null);
            _selectTimer = (string)Registry.GetValue(keyName, "Timer", null);
          
            _AtPlaylist = bool.Parse(Registry.GetValue(keyName, "Playlist", false).ToString());
            _AtZara = bool.Parse(Registry.GetValue(keyName, "Zara", false).ToString());
            _folderPlaylist = (string)Registry.GetValue(keyName, "FolderPl", null);
            _folderZara = (string)Registry.GetValue(keyName, "FolderZr", null);
            _Woeid = (string)Registry.GetValue(keyName, "Woeid", null);
            
        }

        public string Cidade 
        { 
            set {_cidade = value; }
            get { return _cidade; }
        }

        public string Woeid
        {
            set { _Woeid = value; }
            get { return _Woeid; }
        }

        public string Estado
        {
            set { _Estado = value; }
            get { return _Estado; }
        }
        public string StrCep
        {
            set { _cep = value; }
            get { return _cep; }
        }

        public bool AtvPlaylist
        {
            set { _AtPlaylist = value; }
            get { return _AtPlaylist; }
        }
        public bool AtvZara
        {
            set { _AtZara = value; }
            get { return _AtZara; }
        }
        public Servers Server
        {
            set { _Servers = value; }
            get { return _Servers; }
        }

        public string SelectTimer
        {
            set { _selectTimer = value; }
            get { return _selectTimer; }
        }
        public string FolderPlayList
        {
            set { _folderPlaylist = value; }
            get { return _folderPlaylist; }
        }
        public string FolderZara
        {
            set { _folderZara = value; }
            get { return _folderZara; }
        }
    }


}
