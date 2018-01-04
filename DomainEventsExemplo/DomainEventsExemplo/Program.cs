using DomainEventsExemplo.Domain.Entites;
using DomainEventsExemplo.Domain.Events;
using System;

namespace DomainEventsExemplo
{
    internal class Program
    {
        // An event is something that has happened in the past
        private static void Main(string[] args)
        {
            Bootstrap.Start();

            // Preparando o evento
            var idCliente = 10;
            var idObjeto = 574;
            var encomenda = new Encomenda(idCliente, idObjeto);

            var fazerUmaEncomenda = new EncomendaRealizada
                (
                    encomenda.ClienteId,
                    encomenda.ObjetoId,
                    encomenda.DataEntregaPrevista
                );

            // Realizando o evento
            DomainEvents.Raise(fazerUmaEncomenda);
            Console.ReadKey();
        }
    }
}