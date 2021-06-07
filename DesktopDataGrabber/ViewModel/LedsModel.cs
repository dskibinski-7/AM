#define CLIENT
#define GET
#define DYNAMIC

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Http;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DesktopDataGrabber.ViewModel
{
    using Model;
    using System.Collections.Generic;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    /** 
      * @brief View model for MainWindow.xaml 
      */
    public class LedsModel : INotifyPropertyChanged
    {
        #region Properties
        private string _DiodaWiersz = "Podaj wiersz (0-7)";
        public string DiodaWiersz
        {
            get
            {
                return _DiodaWiersz;
            }
            set
            {
                if (_DiodaWiersz != value)
                {
                    _DiodaWiersz = value;
                    OnPropertyChanged("DiodaWiersz");
                }
            }
        }

        private string _DiodaKolumna = "Podaj kolumnę (0-7)";
        public string DiodaKolumna 
        {
            get
            {
                return _DiodaKolumna;
            }
            set
            {
                if (_DiodaKolumna != value)
                {
                    _DiodaKolumna = value;
                    OnPropertyChanged("DiodaKolumna");
                }
            }
        }

        private string _Kolorek = "Podaj kolor red/green/blue/yellow/pink";
        public string Kolorek
        {
            get
            {
                return _Kolorek;
            }
            set
            {
                if (_Kolorek != value)
                {
                    _Kolorek = value;
                    OnPropertyChanged("Kolorek");
                }
            }
        }

        private string _DiodaText = "Wpisz tekst";
        public string DiodaText {
            get
            {
                return _DiodaText;
            }
            set
            {
                if (_DiodaText != value)
                {
                    _DiodaText = value;
                    OnPropertyChanged("DiodaText");
                }
            }
        }
        public ButtonCommand SetDiodsButton { get; set; }
        public ButtonCommand SetTextButton { get; set; }


        #endregion

        /*
         * @brief inicjalizacja przycisków
         */
        public LedsModel()
        {
            SetDiodsButton = new ButtonCommand(SetDiods);
            SetTextButton = new ButtonCommand(SetText);
        }

        /**
         * @brief Przekazanie informacji o zapalanej diodzie
         */
        private void SetDiods()
        {
            string Data = Web.GetPost("http://192.168.56.16/LAB07_CSS_jQ/grab_diods_data.php", "postwiersz", DiodaWiersz, "postkolumna",  DiodaKolumna, "postkolor", Kolorek);
        }

        /**
         * @brief Przekazanie informacji o zapalanym tekscie
         */
        private void SetText()
        {
            string Data = Web.GetPost("http://192.168.56.16/LAB07_CSS_jQ/grab_text_data.php", "posttekst", DiodaText, "postkolor", Kolorek);
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        /**
         * @brief Simple function to trigger event handler
         * @params propertyName Name of ViewModel property as string
         */
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
