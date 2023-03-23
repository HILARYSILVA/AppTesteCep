using AppTesteCep.Model;
using AppTesteCep.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTesteCep.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaCidadesPorEstado : ContentPage
    {

        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade>();
        public BuscaCidadesPorEstado()
        {
            InitializeComponent();

            lst_cidade.ItemsSource = lista_cidades;
            
            
        }

        private void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}