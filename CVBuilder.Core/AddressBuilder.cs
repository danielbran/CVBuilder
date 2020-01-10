namespace CVBuilder.Core
{
    public class AddressBuilder : ICountry, ICounty, ICity, IDataUpdate
    {
        private Address _address;
        private ILanguage _language;
        private AddressBuilder(ILanguage language, Address address)
        {
            address = address ?? new Address(); // if address is null, we will lose the link to the cv.address
            _address = address;
            _language = language;
        }

        public static ICountry Start(ILanguage language, Address address)
        {
            return new AddressBuilder(language, address);
        }

        public ICounty WithCountry(string country)
        {
            _address.Country = country;
            return this;
        }

        public ICity WithCounty(string county)
        {
            _address.County = county;
            return this;
        }

        public IDataUpdate WithCity(string city)
        {
            _address.City = city;
            return this;
        }

        public ILanguage Update()
        {
            var builder = _language as IUpdatableBuilder<Address>;

            if (builder != null)
            {
                builder.UpdateParrentBuilder(_address);
            }

            return _language;
        }
    }

    public interface ICountry
    {
        ICounty WithCountry(string country);
    }

    public interface ICounty
    {
        ICity WithCounty(string county);
    }

    public interface ICity
    {
        IDataUpdate WithCity(string city);
    }

    public interface IDataUpdate
    {
        ILanguage Update();
    }
}
