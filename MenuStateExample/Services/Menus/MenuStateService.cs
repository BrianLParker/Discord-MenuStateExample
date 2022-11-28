namespace MenuStateExample.Services.Menus
{
    public class MenuStateService
    {
        public MenuState MenuState { get; private set; }

        public void ToggleNavMenu() // Yes could be a bool but you may want a 3rd state later ;)
        {
            MenuState = MenuState == MenuState.Open ? MenuState.Closed : MenuState.Open;
            MenuStateChanged?.Invoke(this, this.MenuState);
        }

        public event EventHandler<MenuState> MenuStateChanged = default!;
    }
}
