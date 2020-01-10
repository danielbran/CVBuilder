using System;
using System.Collections.Generic;
using System.Text;

namespace CVBuilder.Core
{
    public class AddressBuilder : ICountry, ICounty, ICity, ILanguage
    {
        private Address _address;
        private AddressBuilder() 
        {
        }

        public static ICountry Start() 
        {
            return new AddressBuilder();
        }

        public ILanguage WithCity(string city)
        {
            _address.City = city;
            return this;
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

        public INationality WithLanguage(string language)
        {
            throw new NotImplementedException();
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
        ILanguage WithCity(string city);
    }
}
