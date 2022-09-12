namespace Sapataria.Infraestrutura.Logging
{
    public interface ILogger
    {
        void Informacao(string message);
        void Alerta(string message);
    }
}
