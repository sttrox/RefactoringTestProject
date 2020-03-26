using System.Windows;

namespace WpfCom
{ 
    public partial class MainWindow : Window
    {

        #region fields

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        #region event user control

        // City---------------->

        private void CityUserControl_ButAddClick(object sender, RoutedEventArgs e)
        {
            DarkPageOn();
            MenuOf();
            UcCity.IsEnabled = false;
            UcCityAdd.Visibility = Visibility.Visible;

        }

        private void CityAddUserControl_OkClick(object sender, RoutedEventArgs e)
        {
            DarkPageOf();
            UcCityAdd.Visibility = Visibility.Hidden;
            MenuOn();
            UcCity.IsEnabled = true;
        }

        private void CityAddUserControl_CloseClick(object sender, RoutedEventArgs e)
        {
            DarkPageOf();
            UcCityAdd.Visibility = Visibility.Hidden;
            MenuOn();
            UcCity.IsEnabled = true;
        }

        // Shop---------------->

        private void ShopUserControl_ButAddClick(object sender, RoutedEventArgs e)
        {
            DarkPageOn();
            MenuOf();
            UcShopAdd.Visibility = Visibility.Visible;
            UcShop.IsEnabled = false;
        }

        private void ShopAddUserControl_OkClick(object sender, RoutedEventArgs e)
        {
            DarkPageOf();
            MenuOn();
            UcShopAdd.Visibility = Visibility.Hidden;
            UcShop.IsEnabled = true;
        }

        private void ShopAddUserControl_CloseClick(object sender, RoutedEventArgs e)
        {
            DarkPageOf();
            MenuOn();
            UcShopAdd.Visibility = Visibility.Hidden;
            UcShop.IsEnabled = true;
        }
        
        #endregion

        #region Файл

        private void CtrExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Справочник

        private void MenuCity(object sender, RoutedEventArgs e)
        {
            UserControlOf();
            UcCity.Visibility = Visibility.Visible;
        }

        private void MenuShop(object sender, RoutedEventArgs e)
        {
            UserControlOf();
            UcShop.Visibility = Visibility.Visible;
        }

        #endregion

        #region Directory methods

        private void MenuOf()
        {
            MenuFile.IsEnabled = false;
            MenuDirectory.IsEnabled = false;
        }

        private void MenuOn()
        {
            MenuFile.IsEnabled = true;
            MenuDirectory.IsEnabled = true;
        }

        private void UserControlOf()
        {
            UcCity.Visibility = Visibility.Hidden;
            UcShop.Visibility = Visibility.Hidden;
        }

        private void DarkPageOn()
        {
            DarkPage.Visibility = Visibility.Visible;
        }

        private void DarkPageOf()
        {
            DarkPage.Visibility = Visibility.Hidden;
        }

        #endregion

    }
}
