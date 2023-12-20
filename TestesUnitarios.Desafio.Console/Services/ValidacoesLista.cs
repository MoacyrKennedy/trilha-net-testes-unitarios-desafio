
namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }

        public IEnumerable<object> ObterNumeroMinimoDaLista(List<int> listaOriginal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObterNumeroMaximoDaLista(List<int> listaOriginal)
        {
            throw new NotImplementedException();
        }

        public bool VerificarSeListaContemNumero(List<int> listaOriginal, int numeroBuscado)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> ExcluirNumerosNegativos(List<int> listaOriginal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> DobrarNumerosDaLista(List<int> listaOriginal)
        {
            throw new NotImplementedException();
        }
    }
}
