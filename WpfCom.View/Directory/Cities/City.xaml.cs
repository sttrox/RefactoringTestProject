using System.Windows;
using System.Windows.Controls;

namespace WpfCom.View.Directory.Cities
{
    /// <summary>
    /// Логика взаимодействия для City.xaml
    /// </summary>
    public partial class City : UserControl
    {
        public City()
        {
            InitializeComponent();
        }


     
        #region methods

        private void CityAdd_Click(object sender, RoutedEventArgs e)
        {
           // RaiseEvent(new RoutedEventArgs(ButAddClickEvent));
        }

        #endregion

        private void btnCityClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
