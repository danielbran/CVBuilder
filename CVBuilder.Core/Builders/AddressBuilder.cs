using CVBuilder.Core.Models;

namespace CVBuilder.Core.Builders
{
    /// <summary>
    /// Address fluent builder
    /// </summary>
    public class AddressBuilder : ICountry, ICounty, ICity, IDataUpdate
    {
        private Address _address;
        private ILanguage _language;

        private AddressBuilder(ILanguage language)
        {
            _address = new Address(); ;
            _language = language;
        }

        public static ICountry Start(ILanguage language)
        {
            return new AddressBuilder(language);
        }

        /// <summary>
        /// Setup the Country
        /// </summary>
        /// <param name="country">The country</param>
        /// <returns>The next property</returns>
        public ICounty WithCountry(string country)
        {
            _address.Country = country;
            return this;
        }

        /// <summary>
        /// Setup the County
        /// </summary>
        /// <param name="county">The county</param>
        /// <returns>The next property</returns>
        public ICity WithCounty(string county)
        {
            _address.County = county;
            return this;
        }

        /// <summary>
        /// Setup the City
        /// </summary>
        /// <param name="country">The city</param>
        /// <returns>The next property</returns>
        public IDataUpdate WithCity(string city)
        {
            _address.City = city;
            return this;
        }

        /// <summary>
        /// Update the address into the CVBuilder
        /// </summary>
        /// <returns>the next property from CVBuilder</returns>
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
}
