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
using Projectgithub.Data.Bll;
using Projectgithub.Data.Layers.Entities;

namespace Projectgithub.Data.Shell
{
    /// <summary>
    /// Interaction logic for ClientWithSelectControl.xaml
    /// </summary>
    public partial class ClientWithSelectControl : UserControl
    {
       
        public ClientWithSelectControl()
        {
            InitializeComponent();
        }

        private async  void GetClientWithSelect_OnClick(object sender, RoutedEventArgs e)
        {
            var task = new Task(() =>
            {
                Dispatcher.Invoke(() =>
                {
                    decorator.IsSplashScreenShown = true;
                });
                var start = DateTime.Now.ToString("HH:mm:ss.fffffffK");
                var listClient = SharedBll.Db.Clients
                    .Select(x => new
                    {
                        CLientId = x.Id,
                        x.FirstName,
                        x.LastName,
                        x.Email,
                        x.PhoneNumber,
                        ClientCreatedAt = x.CreatedAt,
                        ClientUpdatedAt = x.UpdatedAt,
                        DepId = x.Departement.Id,
                        DepartementName = x.Departement.Name,
                        DepCreatedAt = x.Departement.CreatedAt,
                        DepUpdatedAt = x.Departement.UpdatedAt,
                        CityId = x.City.Id,
                        CityName = x.City.Name,
                        CityCreatedAt = x.City.CreatedAt,
                        CityUpdatedAt = x.City.UpdatedAt,
                    })
                    .ToList();
                Dispatcher.Invoke(() =>
                {
                    DataClient.DataSource = listClient;
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
