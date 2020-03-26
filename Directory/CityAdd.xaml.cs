using System.Windows;
using System.Windows.Controls;

namespace WpfCom
{
    /// <summary>
    /// Interaction logic for In_menu.xaml
    /// </summary>
    public partial class CityAdd : UserControl
    {
        public CityAdd()
        {
            InitializeComponent();
        }

        #region routed events

        public static readonly RoutedEvent CityAddCloseClick_Event = EventManager.RegisterRoutedEvent(
            "CityAddCloseClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CityAdd));

        public static readonly RoutedEvent CityAddOk_Event = EventManager.RegisterRoutedEvent(
            "CityAddOkClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CityAdd));


        public event RoutedEventHandler CityAddCloseClick
        {
            add { AddHandler(CityAddCloseClick_Event, value); }
            remove { RemoveHandler(CityAddCloseClick_Event, value); }
        }

        public event RoutedEventHandler CityAddOkClick
        {
            add { AddHandler(CityAddOk_Event, value); }
            remove { RemoveHandler(CityAddOk_Event, value); }
        }

        #endregion
        
        #region methods

        private void CityAddClose_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(CityAddCloseClick_Event));
        }

        private void CityAddOk_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(CityAddOk_Event));
            this.Visibility = Visibility.Hidden;
            
        }

        #endregion

        #region help

        #endregion
    }
}