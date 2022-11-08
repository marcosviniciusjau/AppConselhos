
using AppConselhos;
using AppConselhos.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConselhos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
        }

      
        protected override void OnAppearing()
        {
            try
            {
                lst_conselhos.ItemsSource = App.ListaConselhos;

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem disparador = (MenuItem)sender;

            Conselho conselho_selecionado = (Conselho)disparador.BindingContext;

            bool confirmacao = await DisplayAlert("Tem certeza?",
                                                  "Excluir conselho " + conselho_selecionado.Descricao + "?",
                                                  "Sim", "Não");
            if (confirmacao)
            {
                App.ListaConselhos.Remove(conselho_selecionado);

                //lst_pedagios.ItemsSource = new List<Pedagio>();
                lst_conselhos.ItemsSource = App.ListaConselhos;
            }
        }
    }
}