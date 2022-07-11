namespace Sapataria.Modelo.Infraestrutura
{
    public interface ILogger
    {
        void Informacao(string message);
        void Alerta(string message);        
    }
}
