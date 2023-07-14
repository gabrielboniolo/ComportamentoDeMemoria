﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesalocacaoPorEscopo2
{
    internal class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Product(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string? ToString()
        {
            return $"Produto: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }
    }
}
