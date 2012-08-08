using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort.Comunicacao.Pdv
{
    public class CupomFiscal
    {

        public Cliente cliente { get; set; }

        public CupomFiscal ClienteCupom(Cliente cliente)
        {
            this.cliente = cliente;
            return this;
        }

        public CupomFiscal AdicionarItem(ItemCupom item)
        {
            return this;
        }

    }
}
