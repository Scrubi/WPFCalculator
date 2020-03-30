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

namespace WPFUI3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            double summa1 = double.Parse(yhteen1.Text);
            double summa2 = double.Parse(yhteen2.Text);
            double erotus1 = double.Parse(ero1.Text);
            double erotus2 = double.Parse(ero2.Text);
            double tulos1 = double.Parse(tulo1.Text);
            double tulos2 = double.Parse(tulo2.Text);
            double osam1 = double.Parse(osa1.Text);
            double osam2 = double.Parse(osa2.Text);

            MessageBox.Show($"Summa: {summa1+summa2}\nErotus: {erotus1-erotus2}\nTulo: {tulos1*tulos2}\nOsamäärä: {osam1/osam2}");
        }
    }
}
