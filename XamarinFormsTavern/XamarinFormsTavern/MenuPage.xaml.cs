using System;
using Xamarin.Forms;

namespace XamarinFormsTavern
{
    public partial class MenuPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void OnTavern_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TavernPage());
        }
    }
}
