using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    private Evento evento;

    public CadastroEvento()
    {
        InitializeComponent();

        evento = new Evento();

        BindingContext = evento;
    }

    private async void OnCadastrarClicked(
        object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(evento.NomeEvento) ||
            string.IsNullOrWhiteSpace(evento.LocalEvento) ||
            evento.NumeroParticipantes <= 0 ||
            evento.CustoPorParticipante <= 0)
        {
            await DisplayAlert(
                "Atenção",
                "Preencha todos os campos corretamente.",
                "OK");
            return;
        }

        if (evento.DataTermino.Date < evento.DataInicio.Date)
        {
            await DisplayAlert(
                "Atenção",
                "A data de término não pode ser anterior à data de início.",
                "OK");
            return;
        }

        await Navigation.PushAsync(
            new ResumoEvento(evento));
    }
}