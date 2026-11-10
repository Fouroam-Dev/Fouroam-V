using System;

namespace Fouroam.Client.Core
{
    public enum MenuPage
    {
        Main,
        Status,
        Diagnostics,
        About
    }

    /// <summary>
    /// UI-only, platform-independent navigation state. This contains no
    /// multiplayer transport, game hooks, GTA memory access or online features.
    /// </summary>
    public sealed class MenuState
    {
        private static readonly string[] MainEntries =
        {
            "Estado da sessao",
            "Diagnostico local",
            "Sobre o Fouroam",
            "Fechar"
        };

        public bool IsOpen { get; private set; }
        public MenuPage Page { get; private set; } = MenuPage.Main;
        public int SelectedIndex { get; private set; }
        public string[] Items => (string[])MainEntries.Clone();

        public string Title
        {
            get
            {
                switch (Page)
                {
                    case MenuPage.Status: return "STATUS";
                    case MenuPage.Diagnostics: return "DIAGNOSTICO";
                    case MenuPage.About: return "SOBRE";
                    default: return "FOUROAM V";
                }
            }
        }

        public string Detail
        {
            get
            {
                switch (Page)
                {
                    case MenuPage.Status:
                        return "Cliente in-game: carregado | Co-op: nao implementado";
                    case MenuPage.Diagnostics:
                        return "ScriptHookVDotNet v3 | Interface local ativa";
                    case MenuPage.About:
                        return "Fouroam Dev | Pre-alpha | Codigo proprio e aberto";
                    default:
                        return "Menu experimental no modo Historia";
                }
            }
        }

        public void Toggle()
        {
            IsOpen = !IsOpen;
            Page = MenuPage.Main;
            SelectedIndex = 0;
        }

        public void Close()
        {
            IsOpen = false;
            Page = MenuPage.Main;
            SelectedIndex = 0;
        }

        public void Navigate(int direction)
        {
            if (!IsOpen || Page != MenuPage.Main || direction == 0)
                return;

            int length = MainEntries.Length;
            SelectedIndex = ((SelectedIndex + (direction > 0 ? 1 : -1)) % length + length) % length;
        }

        public void Select()
        {
            if (!IsOpen || Page != MenuPage.Main)
                return;

            switch (SelectedIndex)
            {
                case 0: Page = MenuPage.Status; break;
                case 1: Page = MenuPage.Diagnostics; break;
                case 2: Page = MenuPage.About; break;
                case 3: Close(); break;
            }
        }

        public void Back()
        {
            if (!IsOpen) return;
            if (Page == MenuPage.Main) Close();
            else Page = MenuPage.Main;
        }
    }
}
