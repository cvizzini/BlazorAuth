using BlazorApp1.Shared;

namespace BlazorApp1.Client.HttpRespository
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);
        Task Logout();
    }
}
