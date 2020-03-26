using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Xml.Serialization;
using WpfCom.Model.Directories;
using WpfCom.ViewModel.MVVM;

namespace WpfCom.ViewModel
{
    public class DirectoryViewModel : OnPropertyChangedClass
    {
        public ICommand CityCommand { get; }
        public ICommand CityAddCommand { get; }
        public ICommand CityAddCommandOk { get; }
        public ICommand ShopCommand { get; }

        public ObservableCollection<CityModel> CityOC { get; } = new ObservableCollection<CityModel>();
        public ObservableCollection<CityAddModel> CityAddOC { get; } = new ObservableCollection<CityAddModel>();
        public ObservableCollection<ShopModel> ShopOC { get; } = new ObservableCollection<ShopModel>();

        public DirectoryViewModel()
        {
            CityCommand = new RelayCommand(p => OnCity());
            CityAddCommand = new RelayCommand(p => OnCityAdd());
            CityAddCommandOk = new RelayCommand(p => CityAddOk());
            ShopCommand = new RelayCommand(p => OnShop());
        }

        private void CityAddOk()
        {
        }

        private void OnCity()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<CityModel>));
            ObservableCollection<CityModel> CityOC;
            using (StreamReader wr = new StreamReader("city.xml"))
            {
                CityOC = (ObservableCollection<CityModel>) xs.Deserialize(wr);
            }
        }

        private void OnCityAdd()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<CityAddModel>));
            ObservableCollection<CityAddModel> CityAddOC;
            using (StreamReader wr = new StreamReader("allcity.xml"))
            {
                CityAddOC = (ObservableCollection<CityAddModel>) xs.Deserialize(wr);
            }
        }


        private void OnShop()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<ShopModel>));
            ObservableCollection<ShopModel> ShopOC;
            using (StreamReader wr = new StreamReader("shop.xml"))
            {
                ShopOC = (ObservableCollection<ShopModel>) xs.Deserialize(wr);
            }
        }
    }
}