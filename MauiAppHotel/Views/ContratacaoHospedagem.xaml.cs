using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "Sobre",
                "App modificado por Fabiano Pereira em 30 de outubro de 2025",
                "OK");
            
        }
    }
}
