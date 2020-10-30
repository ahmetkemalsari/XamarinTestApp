using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace opsss.Views
{
    class MyMainPage : MasterDetailPage
    {
        public MyMainPage()
        {
            Title = "Main Page";
            Master = new MyMenuPage();
            Detail = new NavigationPage(new MyDetailPage());
        }
    }
}
