using System.Windows;
using System.Windows.Controls;

namespace WpfCom.View.Directory.Shops
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


        #region methods

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            //RaiseEvent(new RoutedEventArgs(CloseButtonClickEvent));
        }

        private void ShopAddOk_Click(object sender, RoutedEventArgs e)
        {
            //RaiseEvent(new RoutedEventArgs(ShopAddOk_Event));
            this.Visibility = Visibility.Hidden;
        }

        #endregion

        #region help

        #endregion
    }
}