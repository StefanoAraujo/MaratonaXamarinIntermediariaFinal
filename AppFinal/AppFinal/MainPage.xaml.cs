using AppFinal.Service;
using AppFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFinal
{
    public partial class MainPage : ContentPage
    {
        readonly AzureService azureService = new AzureService();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            this.btnLoadData.Clicked += async (sender, e) =>
            {
                var tags = await Api.GetTagsAsync();
                this.lvwTags.ItemsSource = tags;
            };

            this.btnFacebookLogin.Clicked += async (sender, args) =>
            {
                var user = await azureService.LoginAsyn();
                lblInfo.Text = (user != null) ? $"Welcome: {user.UserId}" : "Login Failed! Try again!";
            };
        }
    }
}
