namespace CVBuilder.Core.Models
{
    public class Address
    {
        public Address()
        { }
        public Address(string country, string county, string city, string street, string streetNumber, string postalCode)
        {
            Country = country;
            Country = county;
            City = city;
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
        }
        public string Country { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
    }
}
