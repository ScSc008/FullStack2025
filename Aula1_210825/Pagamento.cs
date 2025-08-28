using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_210825
{
    public class Pagamento
    {
        public int Id { get; set; }
        public decimal valor { get; set; }
        public DateTime data{ get; set; }
        public tipoPagamento tipoPagamento { get; set; }
    }

    public enum tipoPagamento
    {
        credito = 1,
        debito = 2,
        dinheiro = 3,
        pix = 4
    }

}
