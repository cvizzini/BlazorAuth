using BlazorApp1.Client.HttpRespository;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Client.Pages
{
    public partial class Logout
    {
        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await AuthenticationService.Logout();
            NavigationManager.NavigateTo("/");
        }
    }
}
