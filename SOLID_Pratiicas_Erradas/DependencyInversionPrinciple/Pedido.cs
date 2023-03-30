using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Pratiicas_Erradas.DependencyInversionPrinciple
{
    public class Pedido
    {
        public void CriarPedido()
        {
            List<ItemPedido> oItemPedido = new List<ItemPedido>();
        }

        public class ItemPedido
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }


}
