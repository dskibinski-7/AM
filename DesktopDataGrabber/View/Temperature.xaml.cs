using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace DesktopDataGrabber.View
{
    /// <summary>
    /// Interaction logic for Temperature.xaml
    /// </summary>
    public partial class Temperature : Window
    {
        bool isMenuVisible = true;

        /**
         * @brief Inicjalizacja
         */
        public Temperature()
        {
            InitializeComponent();
        }

        /**
         * @brief Chowanie i wysuwanie menu
         */
        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            isMenuVisible = !isMenuVisible;

            if (isMenuVisible)
                this.Menu.Visibility = Visibility.Visible;
            else
                this.Menu.Visibility = Visibility.Collapsed;
        }

        /**
         * @brief Przekierowanie do okna RPY i zamknięcie obecnego
         */
        private void RPYButton(object sender, RoutedEventArgs e)
        {
            MainWindow rpy = new MainWindow();
            rpy.Show();
            this.Close();
        }

        /**
         * @brief Przekierowanie do okna Leds i zamknięcie obecnego
         */
        private void LedsButton(object sender, RoutedEventArgs e)
        {
            Leds ledsy = new Leds();
            ledsy.Show();
            this.Close();
        }

        /**
         * @brief Przekierowanie do okna TableInfo i zamknięcie obecnego
         */
        private void TableInfoButton(object sender, RoutedEventArgs e)
        {
            TableInfo table = new TableInfo();
            table.Show();
            this.Close();
        }

        /**
         * @brief Zmiana wyświetlanego wykresu z tempereturą (zmiana jednostki na °F)
         */
        private void TemperatureChecked(object sender, RoutedEventArgs e)
        {
            TempUnit.Text = "°F";
            CTemperaturePlotView.Visibility = Visibility.Hidden;
            FTemperaturePlotView.Visibility = Visibility.Visible;
        }

        /**
         * @brief Zmiana wyświetlanego wykresu z tempereturą (zmiana jednostki na °C)
         */
        private void TemperatureUnchecked(object sender, RoutedEventArgs e)
        {
            TempUnit.Text = "°C";
            CTemperaturePlotView.Visibility = Visibility.Visible;
            FTemperaturePlotView.Visibility = Visibility.Hidden;
        }

        /**
         * @brief Zmiana wyświetlanego wykresu z wilgotnoscia (zmiana jednostki na 0-1)
         */
        private void HumidityChecked(object sender, RoutedEventArgs e)
        {
            HumUnit.Text = "0-1";
            HumidityPlotView.Visibility = Visibility.Hidden;
            LHumidityPlotView.Visibility = Visibility.Visible;
        }

        /**
         * @brief Zmiana wyświetlanego wykresu z wilgotnoscia (zmiana jednostki na %)
         */
        private void HumidityUnchecked(object sender, RoutedEventArgs e)
        {
            HumUnit.Text = "%";
            HumidityPlotView.Visibility = Visibility.Visible;
            LHumidityPlotView.Visibility = Visibility.Hidden;
        }

        /**
         * @brief Zmiana wyświetlanego wykresu z ciśnieniem (zmiana jednostki na mmHg)
         */
        private void PressureChecked(object sender, RoutedEventArgs e)
        {
            HumUnit.Text = "mmHg";
            PressurePlotView.Visibility = Visibility.Hidden;
            HgPressurePlotView.Visibility = Visibility.Visible;
        }

        /**
         * @brief Zmiana wyświetlanego wykresu z ciśnieniem (zmiana jednostki na mbar)
         */
        private void PressureUnchecked(object sender, RoutedEventArgs e)
        {
            HumUnit.Text = "mbar";
            PressurePlotView.Visibility = Visibility.Visible;
            HgPressurePlotView.Visibility = Visibility.Hidden;
        }


    }
}
