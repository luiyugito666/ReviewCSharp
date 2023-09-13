using System;
namespace SobreEscritura{
    class Program {
        static void Main(string[] args)
        {


            Sale sale = new Sale(4);
            sale.Add(2);
            sale.Add(3);
            sale.Add(5);
            Console.WriteLine(sale.GetTotal());

            SaleWithTax salex = new SaleWithTax(3, 0.18m);
            salex.Add(2);
            salex.Add(3);   
            salex.Add(5);
            Console.WriteLine(salex.GetTotal());


        }
    }


    public class Sale {
        private decimal[] _amounts;
        private int _n;
        private int _end;

        public Sale(int n) {

            _n = n;
            _amounts = new decimal[n];
            _end = 0;
         }

        public void Add(decimal amount) {

            if (_end < _n)
            {
                _amounts[_end]=amount;
                _end++;
            
            }
        }

        public virtual decimal GetTotal()
        {
            decimal result = 0;
            int i = 0;

            while (i < _amounts.Length) { 
            
                result += _amounts[i];  
                i++;    
            
            }

            return result;

        }
       
    }
    public class SaleWithTax:Sale {
        private decimal _tax;
        public SaleWithTax(int n, decimal tax) : base(n) {
            _tax = tax;
        }


        public override decimal GetTotal()
        {
            return base.GetTotal() + base.GetTotal()*_tax;
        }


    }

    

}