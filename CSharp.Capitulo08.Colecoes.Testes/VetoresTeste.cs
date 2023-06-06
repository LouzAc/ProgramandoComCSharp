using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CSharp.Capitulo08.Colecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var inteiros = new int[5];
            inteiros[0] = 21;
            inteiros[1] = -63;
            //inteiros[5] = 11; erro

            var decimais = new decimal[] { 0.4m, 0.9m, 4, 7.8m };
            decimais[2] = 4.5m;

            string[] nomes = { "Vitor", "Avelino" };

            var caracteres = new[] {'a', 'b', 'c'};

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} � {decimais.Length}.");
            
            Console.WriteLine($"O primeiro decimal � {decimais[0]}.");
            Console.WriteLine($"O �ltimo decimal � {decimais[decimais.Length - 1]}.");
            Console.WriteLine($"O �ltimo decimal � {decimais[^1]}.");
            Console.WriteLine($"O �ltimo decimal � {decimais.Last()}.");

            var subConjunto = decimais[0..3];

            foreach (var item in subConjunto)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 7m, 8.9m };

            Array.Resize(ref decimais, 4);

            decimais[3] = 4.6m;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m, 7m, 8.9m, -1.4m, 3 };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -1.4m);
        }

        [TestMethod]
        public void TodasStringEhUmVetorTeste()
        {
            var nome = "Vitor";
            nome += "Avelino";
            // StringBuilder

            Assert.AreEqual(nome[0], 'V');

            foreach (var @char in nome) 
            {
                Console.Write(@char);
            }
        }

    }
}