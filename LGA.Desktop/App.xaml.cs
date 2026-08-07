using LGA.Desktop.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace LGA.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(
            StartupEventArgs e)
        {

            base.OnStartup(e);


            LoginWindow login =
                new LoginWindow();


            login.Show();

        }
    }

}
