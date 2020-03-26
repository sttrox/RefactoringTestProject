using System.Windows;
using System.Windows.Controls;

namespace WpfCom.View.Directory.Shops
{
    /// <summary>
    /// Логика взаимодействия для Shop.xaml
    /// </summary>
    public partial class Shop : UserControl
    {
        public Shop()
        {
            InitializeComponent();
        }

        #region routed events

        public static readonly RoutedEvent ButAddClickEvent = EventManager.RegisterRoutedEvent(
            "ShopAddClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Shop));

        // event control
        public event RoutedEventHandler ShopAddClick
        {
            add { AddHandler(ButAddClickEvent, value); }
            remove { RemoveHandler(ButAddClickEvent, value); }
        }

        #endregion

        #region methods

        private void ShopAdd_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ButAddClickEvent));
        }

        private void btnShopClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        #endregion
    }
}