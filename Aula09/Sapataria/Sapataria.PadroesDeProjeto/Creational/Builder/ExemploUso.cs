using Sapataria.PadroesDeProjeto.Builder.Exemplo;

namespace Sapataria.PadroesDeProjeto.Builder
{
    public class ExemploUso
    {

        public void MyNewMethod()
        {
            var apoliceGenericaExemplo = new SeguroImovel();

            var proposta = new PropostaDeSeguro(apoliceGenericaExemplo);
            proposta.MontarProposta(10M);            
        }
    }
}
