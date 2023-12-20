

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }

        public bool VerificarSeTextoContemPalavra(string texto, string palavraProcurada)
        {
            throw new NotImplementedException();
        }

        public bool VerificarSeTextoTerminaComPalavra(string texto, string palavraProcurada)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObterTamanhoDaPalavra(string palavra)
        {
            throw new NotImplementedException();
        }
    }
}