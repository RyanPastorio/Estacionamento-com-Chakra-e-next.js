using System;

namespace SeuNamespace.Models
{
    public class Evento
    {
        public int Id { get; set; }

        public int EstacionamentoId { get; set; }
        public Estacionamento Estacionamento { get; set; }

        public DateTime HorarioEntrada { get; set; }

        public DateTime? HorarioSaida { get; set; }

        public int UsuarioEntradaId { get; set; }
        public Usuario UsuarioEntrada { get; set; }

        public int? UsuarioSaidaId { get; set; }
        public Usuario UsuarioSaida { get; set; }

        public decimal? ValorPagoCentavos { get; set; }

        // Adicione mais propriedades conforme necessário
    }
}
