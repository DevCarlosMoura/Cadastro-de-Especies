using Cadastro_de_Especies.Models;
using Cadastro_de_Especies.Helpers;
using System;

namespace Cadastro_de_Especies
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnInsert_Clicked(object sender, EventArgs e)
        {
            Especie esp = new Especie();
            esp.Nome = txtNome.Text;
            
            await App.Db.Insert(esp);
            await DisplayAlert("Sucesso", "Espécie cadastrada com sucesso!", "OK");
        }
       
    }

}
