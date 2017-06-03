using AppFinal.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationPage : ContentPage
    {
        readonly AzureService azureService = new AzureService();

        public AuthenticationPage()
        {
            InitializeComponent();

            this.btnFacebookLogin.Clicked += async (sender, args) =>
            {
                var user = await azureService.LoginAsyn();
                lblInfo.Text = (user != null) ? $"Welcome: {user.UserId}" : "Login Failed! Try again!";
            };
        }
    }
}
