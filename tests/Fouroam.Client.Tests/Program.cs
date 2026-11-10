using Fouroam.Client.Core;

static void Check(bool valid, string description)
{
    if (!valid) throw new InvalidOperationException(description);
    Console.WriteLine("[PASS] " + description);
}

var state = new MenuState();
Check(!state.IsOpen && state.Page == MenuPage.Main, "Menu starts closed on main page");
state.Navigate(1);
Check(state.SelectedIndex == 0, "Closed menu does not navigate");
state.Toggle();
Check(state.IsOpen && state.SelectedIndex == 0, "F7 opens menu");
state.Navigate(-1);
Check(state.SelectedIndex == 3, "Up wraps around to final item");
state.Navigate(1);
Check(state.SelectedIndex == 0, "Down wraps around to first item");
state.Select();
Check(state.Page == MenuPage.Status && state.Detail.Contains("nao implementado"),
    "Status does not claim fake co-op connectivity");
state.Navigate(1);
Check(state.SelectedIndex == 0, "Subpages do not change main selection");
state.Back();
Check(state.Page == MenuPage.Main, "Back returns to menu");
state.Navigate(1);
state.Select();
Check(state.Page == MenuPage.Diagnostics, "Diagnostics page opens");
state.Back();
state.Navigate(1);
state.Select();
Check(state.Page == MenuPage.About, "About page opens");
state.Toggle();
Check(!state.IsOpen && state.Page == MenuPage.Main, "F7 closes and resets menu");
state.Toggle();
state.Navigate(-1);
state.Select();
Check(!state.IsOpen, "Close item exits menu");
state.Toggle();
state.Back();
Check(!state.IsOpen, "Escape exits main menu");
Check(state.Items.Length == 4, "Menu has four entries");
Console.WriteLine("[PASS] All Fouroam in-game shell tests completed.");
