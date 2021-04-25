using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace System_RDS
{
    class ServerTemperatura
    {
        private string _cidade, _condicao, _icone, _Woeid;
        private double _temperatura;
        private int _humidade, _apiSel;
        private string _cidade1, _estado1, _folderPlaylist, _folderZara;
        bool _ativoPl, _ativoZr;


        private static System.Timers.Timer aTimer;

        public string Cidade
        {
            set { _cidade = value; }
            get { return _cidade; }
        }
        public string Condicao
        {
            set { _condicao = value; }
            get { return _condicao; }
        }
      

        public double Temperatura
        {
            set { _temperatura = value; }
            get { return _temperatura; }
        }
        public int Humidade
        {
            set { _humidade = value; }
            get { return _humidade; }
        }

        public ServerTemperatura(int selectApi, string cityName, string estado,string SelTimer,string folder1, string folder2,bool ativo1,bool ativo2,string Woeid1)
        {
            _apiSel = selectApi;
            _cidade1 = cityName;
            _estado1 = estado;
            _folderPlaylist = folder1;
            _folderZara = folder2;
            _ativoPl = ativo1;
            _ativoZr = ativo2;
            _Woeid = Woeid1;
            switch (selectApi)
            {
                case 0:
                    hgWeather(Woeid1);
                    SetTimer(SelTimer);
                    break;
                case 1:

                    apiWeatherMap(cityName);
                    SetTimer(SelTimer);
                    break;

                default:
                    break;
            }

        }

        private void apiWeatherMap(string cityName)
        {
            var requisicaoWeb = WebRequest.CreateHttp("http://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&units=metric&appid=1c50b488138958b7a8028947b9aab320&lang=pt_br");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWEB";

            using (var resposta = requisicaoWeb.GetResponse())
            {

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();

                var postWeather = JsonConvert.DeserializeObject<Weathermap>(objResponse.ToString());
                
                _cidade = postWeather.name;
                _temperatura = postWeather.main.temp;
                _humidade = postWeather.main.humidity;
                _condicao = postWeather.weather[0].description.ToString();
                _icone = postWeather.weather[0].icon;
                Console.WriteLine("apiWeatherMap :" + _temperatura);
                if (_ativoPl != false)
                {
                    gravarPlaylist(_folderPlaylist, string.Format("{0:0}", postWeather.main.temp), Convert.ToString(postWeather.main.humidity));
                }
                if (_ativoZr != false)
                {
                    gravarZaraRadio(_folderZara, string.Format("{0:0}", postWeather.main.temp), Convert.ToString(postWeather.main.humidity));
                }
            }
        }
        private void hgWeather(string Woeid1)
        {
       
            var requisicaoWeb = WebRequest.CreateHttp("https://api.hgbrasil.com/weather?woeid="+ Woeid1);
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWEB";

            using (var resposta = requisicaoWeb.GetResponse())
            {

                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();

                var postHgBrasil = JsonConvert.DeserializeObject<HgBrasil>(objResponse.ToString());
               
                Console.WriteLine("hgWeather : " + postHgBrasil.results.temp);
                _cidade = postHgBrasil.results.city;
                _temperatura = postHgBrasil.results.temp;
                _humidade = postHgBrasil.results.humidity;
                _condicao = postHgBrasil.results.description;
                _icone = postHgBrasil.results.img_id;

            
                if (_ativoPl != false)
                {

                    gravarPlaylist(_folderPlaylist,string.Format("{0:0}", postHgBrasil.results.temp), Convert.ToString(postHgBrasil.results.humidity));
                }
                if (_ativoZr != false)
                {
                    gravarZaraRadio(_folderZara, string.Format("{0:0}", postHgBrasil.results.temp), Convert.ToString(postHgBrasil.results.humidity));
                }
            }
        }

        private void gravarPlaylist(string folderpl,string temperatura, string humidade)
        {
            StreamWriter objStreamWriter;

            objStreamWriter = new StreamWriter(@folderpl + @"\htu300.txt");

            objStreamWriter.WriteLine("[HTU300]");


            objStreamWriter.WriteLine("htutemperatura=" + temperatura);

            objStreamWriter.WriteLine("htuumidade=" + humidade + "%");
            
            objStreamWriter.Close();
            
        }

        private void gravarZaraRadio(string folderZara,string tempAtual,string humidadeAr)
        {
            StreamWriter gravarlinhas;

            gravarlinhas = new StreamWriter(@folderZara + @"\temperatura.html");

            gravarlinhas.WriteLine("<HTML>");
            gravarlinhas.WriteLine("Location: [STATION]<BR />");
            gravarlinhas.WriteLine("Condition: [CONDITION]<BR />");
            gravarlinhas.WriteLine("Temperature:" + tempAtual + "<BR />");
            gravarlinhas.WriteLine("Feels Like:0<BR />");
            gravarlinhas.WriteLine("Dew Point: 0<BR />");
            gravarlinhas.WriteLine("Humidity: " + humidadeAr + "<BR />");
            gravarlinhas.WriteLine("Wind: [WIND]<BR />");
            gravarlinhas.WriteLine("Barometer: [BAROMETER]<BR />");
            gravarlinhas.WriteLine("Sunrise: [SUNRISE AMPM]<BR />");
            gravarlinhas.WriteLine("Sunset: [SUNSET AMPM]<BR />");
            gravarlinhas.WriteLine("<BR />");
            gravarlinhas.WriteLine("[UPDATED]");
            gravarlinhas.WriteLine("</HTML>");
            gravarlinhas.Close();

        }

        private void SetTimer(string value)
        {
            
            double timeratu = 0;

            switch (value)
            {
                case "1 min":
                    {
                        timeratu = 59000;
                        break;
                    }

                case "5 min":
                    {
                        timeratu = 295000;
                        break;
                    }

                case "10 min":
                    {
                        
                        timeratu = 590000;
                        break;
                    }

                case "15 min":
                    {
                        timeratu = 885000;
                        break;
                    }

                case "20 min":
                    {
                        timeratu = 1180000;
                        break;
                    }

                case "25 min":
                    {
            
                        timeratu = 1475000;
                        break;
                    }

                case "30 min":
                    {
                        timeratu = 1770000;
                        break;
                    }
            }
            aTimer = new System.Timers.Timer(timeratu);
           
            aTimer.Start();
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Atualizando Temperatura...:  {0:HH:mm:ss.fff}",
                           e.SignalTime);

            switch (_apiSel)
            {
                case 0:
                    hgWeather(_Woeid);

                    break;
                case 1:

                    apiWeatherMap(_cidade1);

                    break;

                default:
                    break;
            }

        }

        public Image IconeTemp()
        {
            object o = Properties.Resources.ResourceManager.GetObject(_icone);
             return o as Image;
        }
       
        
       
    }

}
