using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Projectgithub.Data.Bll;

namespace Projectgithub.Data.Shell
{
    /// <summary>
    /// Interaction logic for ClientWithoutSelectControl.xaml
    /// </summary>
    public partial class ClientWithoutSelectControl : UserControl
    {
        public ClientWithoutSelectControl()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var task = new Task(() =>
            {
                Dispatcher.Invoke(() =>
                {
                    decorator.IsSplashScreenShown = true;
                });
                var start = DateTime.Now.ToString("HH:mm:ss.fffffffK");
                var listClient = SharedBll.Db.Clients.ToList();

                //MessageBox.Show(listClient.Count.ToString());
                

                Dispatcher.Invoke(() =>
                {
                    DataClient.ItemsSource = listClient;
                    var finish = DateTime.Now.ToString("HH:mm:ss.fffffffK");
                    Startresult.Content = start;
                    Endresult.Content = finish;
                    TimeSpan duration = DateTime.Parse(finish).Subtract(DateTime.Parse(start));
                    Totalresult.Content = duration;
                    decorator.IsSplashScreenShown = false;
                });
            });
            task.Start();
            await task;
            task.Dispose();
        }

        
    }
}
