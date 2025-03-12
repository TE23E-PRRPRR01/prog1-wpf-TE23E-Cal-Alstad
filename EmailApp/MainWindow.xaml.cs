using System.Windows;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Data.Common;

namespace EmailApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {

        //läs av epost & meddelanden
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text;

        //koppla upp på mail-server
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("user", "pass");


        if (epost != "" && meddelande != "")
        {
            smtp.Send("id", epost, "Titel på mejlet", meddelande)
            lblStatus.Content = " Meddelande Skickats!";
        }
        else
        {
            lblStatus.Content = "Antingen saknas Meddelande och/eller Epost";
        }


    }

    private void ChangedEpost(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;

        //kontrolera format med regex
        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        if (!Regex.IsMatch(epost, regexEpost))
        {
            // Visa felmeddelande
            lblStatus.Text = "Du måste ange en giltig epostadress!";
        }
        else
        {
                
        }
    }
}