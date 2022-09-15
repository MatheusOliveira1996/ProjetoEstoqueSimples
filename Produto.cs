﻿using System.Globalization;

namespace ProjetoEstoqueSimples {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos (int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString () {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidade, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
