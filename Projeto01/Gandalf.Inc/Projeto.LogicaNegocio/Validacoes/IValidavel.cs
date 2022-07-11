namespace Validadores
{
    public interface IValidavel
    {
        bool EstaValido(string parametros);
        string GerarValorParaTestes(bool formatado = false);
        string ToStringFormatado(string parametros);
    }
}
