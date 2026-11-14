using System;

namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; } = string.Empty;

        public DateTime DataInicio { get; set; } = DateTime.Today;

        public DateTime DataTermino { get; set; } = DateTime.Today;

        public int NumeroParticipantes { get; set; }

        public string LocalEvento { get; set; } = string.Empty;

        public decimal CustoPorParticipante { get; set; }

        // Calcula a duração do evento
        public TimeSpan Duracao
        {
            get
            {
                return DataTermino.Date - DataInicio.Date;
            }
        }

        // Retorna a duração em dias
        public int DuracaoDias
        {
            get
            {
                return Duracao.Days;
            }
        }

        // Calcula o custo total
        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}
