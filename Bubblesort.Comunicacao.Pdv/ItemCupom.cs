using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort.Comunicacao.Pdv
{
    public class ItemCupom
    {
        public long numero { get; set; }
        public Produto produto { get; set; }
         
        public decimal valorUnitario { get; set; }
        public decimal quantidade { get; set; }
        public decimal acrescimoNototal { get; set; }
        public decimal descontoNoTotal { get; set; }
        public decimal valorTotal { get; set; }

    } 
}
