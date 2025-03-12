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

namespace JulklappsListan;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    // Våra Variabler
    int maxJulklappar = 0;
    List<string> listaJulklappar = [];



    public MainWindow()
    {
        InitializeComponent();

        //Koppla list till Listbox
        lsbJulklappar.ItemsSource = listaJulklappar ;

        //Lås Gränssnittet
        stpInmatning.IsEnabled = false;
        stpListan.IsEnabled = false;

    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        //Läs av Textbox
        string antal = txbAntal.Text;
        

        //Första enkel kontroll
        if (antal == "")
        {
            txbStatus.Text = "Vänligen ange ett heltal";
        }
        else
        {
            bool lyckas = int.TryParse(antal, out int talet);
            if (lyckas)
            {
                maxJulklappar = talet;
                txbStatus.Text = $"Maximala antalet julklappar är {talet}";

               

                //Lås Gränssnittet
                stpMax.IsEnabled = false;
                stpInmatning.IsEnabled = true;
                stpListan.IsEnabled = true;

            }
            else
            {
                txbStatus.Text = "Vänligen ange ett heltal";
            }
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        //Läs av rutorn
        string julklapp = txbJulklapp.Text;
        string mottagare = txbMottagare.Text;

        //Första enkel kontroll
        if (julklapp  == "" || mottagare == "")
        {
            txbStatus.Text = "Vänligen ange både julklapp och mottagare";
        }
        else
        {
            listaJulklappar.Add($"{julklapp} till {mottagare}");
            lsbJulklappar.Items.Refresh();
        }
    }
    

    private void KlickBytUt(object sender, RoutedEventArgs e)
    {
        
    }


}