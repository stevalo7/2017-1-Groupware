using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Topicos.Calculadora.Dominio.Validaciones
{
    internal class RealizarValidaciones
        
    {
        public const double LaConstante = 0;
        public bool LaListaContieneAlMenosUnElemento (IEnumerable<double> laLista)
        {
            return (laLista.Count() > 0);
        }

        public bool LaListaNoContieneNingunElemento(IEnumerable<double> laLista)
        {
            return (! LaListaContieneAlMenosUnElemento (laLista));
        }



    }
}