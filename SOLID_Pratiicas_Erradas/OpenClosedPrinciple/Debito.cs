namespace SOLID_Pratiicas_Erradas.OpenClosedPrinciple
{
    public enum TipoDebito { ContaCorrente, Poupanca }

    internal class Debito
    {
        public void Debitar(int valor, TipoDebito tipo)

        {
            if (tipo == TipoDebito.Poupanca)
            {
                // Debita Poupanca

            }

            if (tipo == TipoDebito.ContaCorrente)

            {

                // Debita ContaCorrente

            }

        }

    }
}
