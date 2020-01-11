using CVBuilder.Core.Models;

namespace CVBuilder.Core
{
    public interface IContactAddress
    {
        ICountry WithAddress();
        ILanguage WithAddress(Address address);
    }
}


