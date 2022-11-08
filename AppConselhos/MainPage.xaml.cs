using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppConselhos.Model;
using AppConselhos.Services;
using System.Collections;


namespace AppConselhos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
            this.Title = "Conselhos";
            this.BindingContext = new Conselho();
        }
        private async void btnConselho_Clicked(object sender, EventArgs e)
        {
            try
            {
               
                    Conselho conselho_descricao = await DataServices.GetConselho();
                    this.BindingContext = conselho;
         

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lista());
        }

    }
}