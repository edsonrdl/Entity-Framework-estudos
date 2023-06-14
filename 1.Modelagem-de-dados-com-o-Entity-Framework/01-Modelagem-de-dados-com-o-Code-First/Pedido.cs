using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Modelagem_de_dados_com_o_Entity_Framework._01_Modelagem_de_dados_com_o_Code_First
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
