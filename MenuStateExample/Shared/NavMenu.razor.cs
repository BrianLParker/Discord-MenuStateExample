using MenuStateExample.Services.Menus;
using Microsoft.AspNetCore.Components;

namespace MenuStateExample.Shared
{
    public partial class NavMenu
    {
        [Inject]
        private MenuStateService Menu { get; set; }

        private MenuState MenuState => Menu.MenuState;

        private string? NavMenuCssClass => MenuState == MenuState.Closed ? "collapse" : null;

        protected override void OnInitialized()
        {
            Menu.MenuStateChanged += (sender, state) => StateHasChanged();
        }
    }
}