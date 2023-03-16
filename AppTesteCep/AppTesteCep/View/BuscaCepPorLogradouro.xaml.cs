using AppTesteCep.Model;
using AppTesteCep.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTesteCep.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaCepPorLogradouro : ContentPage
    {
        public BuscaCepPorLogradouro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                 carregando.IsRunning = true;

                List<Cep> arr_ceps = await DataService.GetCepsByLogradouro(txt_logradouro.Text);
                
                list_ceps.ItemsSource= arr_ceps;

            }catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "ok");

                Console.WriteLine(ex.StackTrace);


            }finally
            {
                carregando.IsRunning = false;

            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
 
}
