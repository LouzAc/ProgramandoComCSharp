﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Capitulo08.Colecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>(/*1000*/) { 8, -73, 20, 0 };

            inteiros.Add(1);
            inteiros.Add(3);

            inteiros[0] = 10;
            //inteiros[10] = 111;

            inteiros.Add(27);
            inteiros.Add(-1);

            var maisInteiros = new List<int> { 16, 38, -7, 8 };

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(2, 42);

            inteiros.Remove(8);

            inteiros.RemoveAt(5);

            inteiros.Sort();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();

            var ultimo = inteiros[^1];
            ultimo = inteiros[inteiros.Count - 1];
            ultimo = inteiros.Last();

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");
            }
        }

        [TestMethod]
        public void DictionaryTeste()// hash table
        {
          var feriados = new Dictionary<DateTime, string>();

            feriados.Add(new DateTime(2023, 6, 8), "Corpus Cristi");
        }
    }
}
