 
namespace SOLID_PraticasCorretas.DependencyInversionPrinciple
{
    public class Pedido
    {
        private ItemPedido _oItemPedido;
        public ItemPedido OitemPedido
        {
            get { return _oItemPedido; }
            set { _oItemPedido = value; }
        }
        public void CriarPedido()
        {
            if(OitemPedido == null)
                throw new Exception("Não existem Itens para esse Pedido.");
        }
    }     
}
