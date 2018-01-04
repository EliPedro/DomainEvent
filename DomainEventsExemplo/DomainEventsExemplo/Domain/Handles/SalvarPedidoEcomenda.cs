using DomainEventsExemplo.Domain.Entites;
using DomainEventsExemplo.Domain.Handles;
using System;

namespace DomainEventsExemplo.Domain.Events
{
    public class SalvarPedidoEcomenda : IHandle<EncomendaRealizada>
    {
        public void Handle(EncomendaRealizada args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Encomenda {args.ObjetoId} do cliente {args.ClientId}");
        }
    }
}