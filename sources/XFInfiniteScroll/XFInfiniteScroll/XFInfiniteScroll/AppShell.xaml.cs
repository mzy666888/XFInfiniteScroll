using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFInfiniteScroll.ViewModels;
using XFInfiniteScroll.Views;

namespace XFInfiniteScroll
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
