using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace System_RDS
{
    class BuscaCep
    {
        private string _cidade, _estado, _Woeid;
   
        public BuscaCep(string cepcity)
        {
              var requisicaoWeb = WebRequest.CreateHttp("https://ws.apicep.com/cep/"+ cepcity+".json");
              requisicaoWeb.Method = "GET";
             requisicaoWeb.UserAgent = "RequisicaoWEB";

               using (var resposta = requisicaoWeb.GetResponse())
              {

                 var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
               object objResponse = reader.ReadToEnd();

                CepsAtr classCepsAtr = JsonConvert.DeserializeObject<CepsAtr>(objResponse.ToString());

                _cidade = classCepsAtr.city;
                _estado = classCepsAtr.state;
                BuscarWoeid(classCepsAtr.city, classCepsAtr.state);
            

            }
        }

        private void BuscarWoeid(string _refCidade,string _refEstado)
        {
       
            var requisicaoWeb = WebRequest.CreateHttp("https://api.hgbrasil.com/stats/find_woeid?key=17284dd0&format=json-cors&sdk_version=console&city_name="+ _refCidade +","+ _refEstado);
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWEB";

            using (var resposta = requisicaoWeb.GetResponse())
            {

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();

                Woeid classWoeid = JsonConvert.DeserializeObject<Woeid>(objResponse.ToString());
                _Woeid = classWoeid.woeid.ToString();
            
            }
        }
        public string Cidade
        {
            set { _cidade = value; }
            get { return _cidade; }
        }
        public string Woeid
        {
            set { _Woeid = value; }
            get { return _Woeid; }
        }
        public string Estado
        {
            set { _estado = value; }
            get { return _estado; }
        }
    }


}
