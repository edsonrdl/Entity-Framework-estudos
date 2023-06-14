using _1.Modelagem_de_dados_com_o_Entity_Framework._01_Modelagem_de_dados_com_o_Code_First;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Modelagem_de_dados_com_o_Entity_Framework
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
