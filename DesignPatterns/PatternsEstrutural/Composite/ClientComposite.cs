using DesignPatterns.PatternsEstrutural.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Composite
{
    public class ClientComposite
    {
        public void EfetuarCompra()
        {
            ComponentModel product1 = new ProductLeaf("Caneca", 25.00);
            ComponentModel product2 = new ProductLeaf("Camiseta", 40.00);
            ComponentModel product3 = new ProductLeaf("Chaveiro", 5.00);
            ComponentModel product4 = new ProductLeaf("Estátua", 500.00);

            ComponentModel smallBox = new ProductsComposite();
            smallBox.Add(product1, product2, product3);

            ComponentModel bigBox = new ProductsComposite();
            bigBox.Add(smallBox, product4);

            var valorTotal = bigBox.Operation();

            Console.WriteLine($"\nValor Total: {valorTotal.ToString("C")}");
        }
    }
}
