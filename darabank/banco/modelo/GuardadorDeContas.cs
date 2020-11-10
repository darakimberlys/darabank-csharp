namespace darabank.banco.modelo
{
    public class GuardadorDeContas
    {
        private Conta[] referencias;
        private int posicaoLivre;

        public GuardadorDeContas()
        {
            referencias = new Conta[10];
            posicaoLivre = 0;
        }

        public void Adiciona(Conta refeConta)
        {
            referencias[posicaoLivre] = refeConta;
            posicaoLivre++;
        }

        public int GetQuantidadeElementos()
        {
            return posicaoLivre;
        }

        public Conta GetReferencia(int posicao)
        {
            return referencias[posicao];
        }
    }
}
