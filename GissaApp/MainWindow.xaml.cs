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

namespace GissaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //slumpa fram ett tal 1-1000
    int slumptal = Random.Shared.Next(1, 1000);
    List<int> listaGissningar = [];

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        //läs av ruta gissning
        string input = txbGissning.Text;

        //Konvertera till heltal 
        bool lyckades = int.TryParse(input, out int gissning);

        if (lyckades)
        {
            // Lagra i listan
            listaGissningar.Add(gissning);

            //jämföra gissning med slumptal
            if (gissning == slumptal)
            {
                txbResultat.Text = $"Din gissning var rätt ({gissning})";
            }
            else if (gissning > slumptal)
            {
                txbResultat.Text = $"Din gissning var för hög ({gissning})";
            }
            else
            {
                txbResultat.Text = $"Din gissning var för låg ({gissning})";
            }
        }
        else
        {
            txbResultat.Text = "Ogiltig inmatning. Vänligen försök igen";
            
        }

    }

    //Skriver in facit i resultatboxen
    private void KlickVisaFacit(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = $"Rätt svar är {slumptal}";
    }

    private void KlickVisaGissningar(object sender, RoutedEventArgs e)
    {
         txbGissningar.Text = "";

        //Skriv ut alla gissningar som finns i listan i gissnings textbox
        foreach (var tal in listaGissningar)
        {
            txbGissningar.Text += $"{tal}\n";
        }

        
    }

   
    private void KlickStartaOm(object sender, RoutedEventArgs e)
    {
        //slumpa fram nytt tal
        slumptal = Random.Shared.Next(1, 1000);

        //Rensar textboxar
        txbResultat.Text = "";

        txbGissning.Text = "";

        txbGissningar.Text = "";

        listaGissningar = [];

    }
}

