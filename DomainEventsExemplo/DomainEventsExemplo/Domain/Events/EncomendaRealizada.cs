using DomainEventsExemplo.Domain.Interfaces;
using System;

namespace DomainEventsExemplo.Domain.Entites
{
    public class EncomendaRealizada : IDomainEvent
    {
        public EncomendaRealizada(int clienteId, int objetoId, DateTime dataEntrega)
        {
            ClientId = clienteId;
            ObjetoId = objetoId;
            DataEntrega = dataEntrega;
        }

        public int ClientId { get; }
        public int ObjetoId { get; }
        public DateTime DataEntrega { get; }
    }
}