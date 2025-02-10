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

namespace AreaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RäknaUt(object sender, RoutedEventArgs e)
    {
        int Bredd = int.Parse(vBredd.Text);
        int Höjd = int.Parse(vHöjd.Text);

        int Area = Bredd * Höjd;

        Resultat.Text = Area.ToString();
    }

    private void Clear(object sender, RoutedEventArgs e)
    {
        vBredd.Text = "".ToString();
        vHöjd.Text = "".ToString();
        Resultat.Text = "".ToString();
    }
}