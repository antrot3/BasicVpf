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

namespace BsciWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Covik covik { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            covik = new Covik() { Id = 1, Ime = "Rota" };

            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"First Name : {firstName.Text}");

        }
    }
    public class Covik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
    }
}
