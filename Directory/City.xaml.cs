using System.Windows;
using System.Windows.Controls;

namespace WpfCom
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


        #region routed events
        public static readonly RoutedEvent ButAddClickEvent = EventManager.RegisterRoutedEvent(
            "CityAddClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(City));

        // event control
        public event RoutedEventHandler CityAddClick
        {
            add { AddHandler(ButAddClickEvent, value); }
            remove { RemoveHandler(ButAddClickEvent, value); }
        }

        #endregion

        #region methods

        private void CityAdd_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ButAddClickEvent));
        }

        #endregion

        private void btnCityClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
