namespace WpfCom
{
    #region Справочник городов с магазинами
    public class CityModel : OnPropertyChangedClass
    {
        private int _id;
        private string _city;

        public int ID { get => _id; set => SetProperty(ref _id, value); }
        public string City { get => _city; set => SetProperty(ref _city, value); }

        public CityModel()
        {

        }
    }
    #endregion

    #region Справочник всех городов
    public class CityAddModel : OnPropertyChangedClass
    {
        private int _id;
        private string _city;

        public int ID { get => _id; set => SetProperty(ref _id, value); }
        public string City { get => _city; set => SetProperty(ref _city, value); }

        public CityAddModel()
        {

        }
    }
    #endregion

    #region Справочник магазинов
    public class ShopModel : OnPropertyChangedClass
    {
        private int _id;
        private string _division;
        private string _code_shop;
        private string _name_shop;
        private string _post_code_shop;
        private string _city_shop;
        private string _address_shop;
        private string _format_shop;
        private string _legal_entity_shop;
        private string _email_shop;
        private string _status_shop;
        private string _note_shop;

        public int ID { get => _id; set => SetProperty(ref _id, value); }
        public string Division { get => _division; set => SetProperty(ref _division, value); }
        public string CodeShop { get => _code_shop; set => SetProperty(ref _code_shop, value); }
        public string NameShop { get => _name_shop; set => SetProperty(ref _name_shop, value); }
        public string PostCodeShop { get => _post_code_shop; set => SetProperty(ref _post_code_shop, value); }
        public string CityShop { get => _city_shop; set => SetProperty(ref _city_shop, value); }
        public string AddressShop { get => _address_shop; set => SetProperty(ref _address_shop, value); }
        public string FormatShop { get => _format_shop; set => SetProperty(ref _format_shop, value); }
        public string LegalEntityShop { get => _legal_entity_shop; set => SetProperty(ref _legal_entity_shop, value); }
        public string EmailShop { get => _email_shop; set => SetProperty(ref _email_shop, value); }
        public string StatusShop { get => _status_shop; set => SetProperty(ref _status_shop, value); }
        public string NoteShop { get => _note_shop; set => SetProperty(ref _note_shop, value); }

        public ShopModel()
        {

        }
    }
    #endregion

}
