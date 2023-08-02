using DesignPatterns.PatternsEstrutural.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsEstrutural.Composite
{
    public class ProductLeaf : ComponentModel
    {
        private string _name;
        private double _value;

        public ProductLeaf(string name, double value)
        {
            _name = name;
            _value = value;
        }

        public override void Add(params ComponentModel[] components)
        {
            Console.WriteLine("Não é possível adicionar itens em um objeto do tipo Leaf");
        }

        public override ComponentModel GetChild(int index)
        {
            Console.WriteLine("Não é possível obter itens em uma classe do tipo Leaf");
            return null;
        }

        public override double Operation()
        {
            Console.WriteLine($"Produto: {_name}\nValor: {_value.ToString("C")}");
            Console.WriteLine(new String('-', 40));
            return _value;
        }

        public override void Remove(ComponentModel components)
        {
            Console.WriteLine("Não é possível remover itens em um objeto do tipo Leaf");
        }
    }
}
