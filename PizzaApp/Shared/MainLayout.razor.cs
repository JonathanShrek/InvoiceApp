﻿using Microsoft.AspNetCore.Components;
using MudBlazor;
using PizzaApp.Components;
using PizzaApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public partial class MainLayout : IDisposable
    {
        [Inject] public ThemeService ThemeService { get; set; }

        bool MenuOpened { get; set; }

        protected override void OnInitialized()
        {
            ThemeService.OnChange += StateHasChanged;
        }

        void DrawerToggle()
        {
            MenuOpened = !MenuOpened;
        }

        public void Dispose()
        {
            ThemeService.OnChange -= StateHasChanged;
        }
    }
}
