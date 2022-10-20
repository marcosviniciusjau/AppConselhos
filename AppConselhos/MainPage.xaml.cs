using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppConselhos.Model;
using AppConselhos.Services;


namespace AppConselhos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
            this.Descricao = "Conselhos";l
            this.BindingContext = new Conselho();
        }

        private async void btnConselho_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(conselhoEntry.Text))
                {
                    Conselho conselho = await DataServices.GetConselho(conselhoEntry.Text);
                    this.BindingContext = conselho;
                    btnConselho.Text = "Novo Conselho";
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}