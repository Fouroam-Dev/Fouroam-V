using System;
using System.Drawing;
using System.Windows.Forms;
using Fouroam.Client.Core;
using GTA;
using GTA.UI;

namespace Fouroam.GameClient
{
    /// <summary>
    /// A local-only, single-player visual client shell.
    /// It never calls online services, hooks multiplayer game logic, or
    /// changes game memory, NPCs, vehicles, missions or official world state.
    /// </summary>
    public sealed class FouroamGameScript : Script
    {
        private readonly MenuState _menu = new MenuState();

        private static readonly Color Background = Color.FromArgb(218, 9, 12, 22);
        private static readonly Color RowColor = Color.FromArgb(225, 22, 27, 43);
        private static readonly Color Blue = Color.FromArgb(0, 110, 254);
        private static readonly Color White = Color.FromArgb(247, 249, 252);
        private static readonly Color Muted = Color.FromArgb(159, 169, 185);

        public FouroamGameScript()
        {
            Interval = 0;
            Tick += OnTick;
            KeyDown += OnKeyDown;
            GTA.UI.Notification.Show("Fouroam-V pre-alpha carregado. Pressione F7 para abrir o menu.");
        }

        private void OnKeyDown(object sender, KeyEventArgs args)
        {
            switch (args.KeyCode)
            {
                case Keys.F7:
                    _menu.Toggle();
                    break;
                case Keys.Escape:
                case Keys.Back:
                    _menu.Back();
                    break;
                case Keys.Up:
                    _menu.Navigate(-1);
                    break;
                case Keys.Down:
                    _menu.Navigate(1);
                    break;
                case Keys.Enter:
                    _menu.Select();
                    break;
            }
        }

        private void OnTick(object sender, EventArgs args)
        {
            if (!_menu.IsOpen) return;

            // The SHVDN draw API uses a virtual 1280x720 canvas;
            // no direct game state changes occur here.
            new ContainerElement(new PointF(70, 84), new SizeF(436, 376), Background).Draw();
            new ContainerElement(new PointF(70, 84), new SizeF(436, 7), Blue).Draw();
            Write("FOUROAM", 94f, 108f, .66f, White);
            Write("V / PRE-ALPHA", 332f, 122f, .30f, Muted);
            Write(_menu.Title, 94f, 162f, .35f, Blue);

            if (_menu.Page == MenuPage.Main)
            {
                var items = _menu.Items;
                for (int i = 0; i < items.Length; i++)
                {
                    float y = 209 + i * 46;
                    bool selected = _menu.SelectedIndex == i;
                    new ContainerElement(
                        new PointF(91, y),
                        new SizeF(396, 39),
                        selected ? Blue : RowColor).Draw();
                    Write((selected ? ">  " : "   ") + items[i],
                        104f, y + 5, .34f, White);
                }
                Write("F7 MENU  |  CIMA/BAIXO  |  ENTER  |  ESC", 94f, 425f, .28f, Muted);
            }
            else
            {
                new ContainerElement(
                    new PointF(91, 206), new SizeF(396, 130), RowColor).Draw();
                Write(_menu.Detail, 103f, 224f, .30f, White);
                Write("Interface e diagnostico local apenas.", 103f, 270f, .29f, Muted);
                Write("Nenhum multiplayer esta ativo no GTA V.", 103f, 302f, .29f, Muted);
                Write("ESC VOLTAR   |   F7 FECHAR", 94f, 425f, .28f, Muted);
            }
        }

        private static void Write(string text, float x, float y, float scale, Color color)
        {
            new TextElement(text, new PointF(x, y), scale, color).Draw();
        }
    }
}
