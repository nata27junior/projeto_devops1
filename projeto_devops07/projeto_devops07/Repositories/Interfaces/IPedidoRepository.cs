using projeto_devops07.Models;
using System.Collections.Generic;

namespace projeto_devops07.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
        Pedido GetPedidoById(int pedidoId);
        List<Pedido> GetPedidos();
    }
}
