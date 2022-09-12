namespace Sapataria.PadroesDeProjeto.Creational.ObjectPool
{
    public abstract class FilaProcessamento<T>
    {
        private readonly bool _pronto;
        private readonly Dictionary<T, bool> _filaEmProcessamento;

        protected FilaProcessamento(bool pronto, Dictionary<T, bool> filaEmProcessamento)
        {
            _pronto = pronto;
            _filaEmProcessamento = filaEmProcessamento;
        }

        public abstract T Enfileirar(T pedido);
        public abstract void RemoverDaFila(T pedido);

        public int ObterPosicoesOcupadasNaFila => _filaEmProcessamento.Count;
    }
}
