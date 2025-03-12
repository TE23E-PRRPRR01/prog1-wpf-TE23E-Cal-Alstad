using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SlumpaTal(object sender, RoutedEventArgs e)
    {
        if (!int.TryParse(Maxgräns.Text, out int max))
        {
            SlumpTalOP.Text = "Felaktig inmatning maxgräns".ToString();
            return;
        }

        if (!int.TryParse(Mingräns.Text, out int min))
        {
            SlumpTalOP.Text = "Felaktig inmatning Mingräns".ToString();
            return;
        }

        int slumptal = Random.Shared.Next(min, max +1);
        SlumpTalOP.Text = slumptal.ToString();
    }
}   