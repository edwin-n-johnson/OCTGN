﻿using Octgn.Sdk;
using Octgn.Sdk.Extensibility.Desktop;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Octgn.Desktop.Interfaces.Easy
{
    public partial class MenuScreen : Screen
    {
        private readonly MenuPlugin _menuPlugin;

        [Obsolete("For designer only")]
        public MenuScreen() {
            InitializeComponent();
        }

        public MenuScreen(IPluginDetails gamePluginDetails, MenuPlugin menuPlugin) {
            _menuPlugin = menuPlugin ?? throw new ArgumentNullException(nameof(menuPlugin));

            Title = gamePluginDetails.Name;

            InitializeComponent();

            foreach (var item in menuPlugin.MenuItems) {
                var button = new Button {
                    Content = item.Text,
                    HorizontalAlignment = HorizontalAlignment.Stretch
                };

                button.Click += async (sender, args) => {
                    this.IsEnabled = false;
                    try {
                        await Task.Delay(200);

                        await item.OnClick();
                    } catch (Exception ex) {
                        //TODO: Shutodwn error
                    } finally {
                        this.IsEnabled = true;
                    }
                };

                ButtonList.Items.Add(button);
            }

            //var converter = new BrushConverter();
            //var brush = (Brush)converter.ConvertFromString(plugin.Theme.Background);

            //this.Background = brush;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e) {
            NavigationService.NavigateTo(new LoginScreen(this));
        }
    }
}
