using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bematech.Fiscal.ECF;

namespace Bubblesort.Comunicacao.Pdv
{
    public class Impressora
    {
        ImpressoraFiscal _printer;

        public CupomFiscal AbrirCupom()
        {
            CupomFiscal cupom = new CupomFiscal();            
            return cupom;
        }        

        public void AbrirImpressora()
        {
            _printer = ImpressoraFiscal.Construir();
        }

    }
}
