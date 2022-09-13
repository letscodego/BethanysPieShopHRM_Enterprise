using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.UI.Services
{
    public interface IEmailService
    {
        void SendEmail(Email email);
    }
}
