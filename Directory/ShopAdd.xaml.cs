using System.Windows;
using System.Windows.Controls;

namespace WpfCom
{
    /// <summary>
    /// Interaction logic for In_menu.xaml
    /// </summary>
    public partial class ShopAdd : UserControl
    {
        public ShopAdd()
        {
            InitializeComponent();
        }

        #region routed events

        public static readonly RoutedEvent CloseButtonClickEvent = EventManager.RegisterRoutedEvent(
            "ShopAddCloseClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CityAdd));

        public static readonly RoutedEvent ShopAddOk_Event = EventManager.RegisterRoutedEvent(
            "ShopAddOkClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CityAdd));


        public event RoutedEventHandler ShopAddCloseClick
        {
            add { AddHandler(CloseButtonClickEvent, value); }
            remove { RemoveHandler(CloseButtonClickEvent, value); }
        }

        public event RoutedEventHandler ShopAddOkClick
        {
            add { AddHandler(ShopAddOk_Event, value); }
            remove { RemoveHandler(ShopAddOk_Event, value); }
        }

        #endregion
        
        #region methods

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(CloseButtonClickEvent));
        }

        private void ShopAddOk_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ShopAddOk_Event));
            this.Visibility = Visibility.Hidden;
        }

        #endregion

        #region help

        #endregion
    }
}