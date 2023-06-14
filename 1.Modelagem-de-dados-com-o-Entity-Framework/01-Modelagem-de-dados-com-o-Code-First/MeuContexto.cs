using Microsoft.EntityFrameworkCore;

namespace _1.Modelagem_de_dados_com_o_Entity_Framework._01_Modelagem_de_dados_com_o_Code_First
{
    public class MeuContexto: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
