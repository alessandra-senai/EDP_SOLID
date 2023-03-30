
namespace SOLID_Pratiicas_Erradas.SingleResponsibilityPrinciple
{
    internal class DebitoContaCorrente
    {
        public void ValidarSaldo(int valor)
        {
            Console.WriteLine($"O valor do saldo é de: {valor}");
        }

        public void DebitarConta(int valor)
        {
            Console.WriteLine($"O valor a debitar em conta é de: {valor}");
        }

        public void EmitirComprovante()
        {
            Console.WriteLine("Comprovante emitido com sucesso!");
        }

    }
}
