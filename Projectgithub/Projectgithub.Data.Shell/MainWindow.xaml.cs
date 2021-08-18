using System;
using System.Windows;
using Projectgithub.Data.Bll;

namespace Projectgithub.Data.Shell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SharedBll.Db = new AppDbContext(connectionString: "data source=(local);initial catalog=TestDb;integrated security = True");
        }

        private void Djaloul_OnClick(object sender, RoutedEventArgs e)
        {
            stacked.Children.Clear();
            ClientWithoutSelectControl clientWithoutSelectControl = new ClientWithoutSelectControl();
            stacked.Children.Add(clientWithoutSelectControl);
        }

        private void Nedjmo_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
