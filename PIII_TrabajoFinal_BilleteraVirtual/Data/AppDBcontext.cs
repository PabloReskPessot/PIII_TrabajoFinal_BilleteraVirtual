namespace PIII_TrabajoFinal_BilleteraVirtual.Data
{
    using Microsoft.EntityFrameworkCore;
    using PIII_TrabajoFinal_BilleteraVirtual.Controllers;
    using PIII_TrabajoFinal_BilleteraVirtual.Modelos;
    using System;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Moneda> Moneda { get; set; }
        public DbSet<Cartera> Cartera { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }


        // no funciono asi que elimino la fk usuario2 y listo 

        //// esta parte la agrego enteramente el chat para evitar el comportamiento cascada entre usuario y usuario2 en transacciones
        //// la realidad es que se lo pedi porque no se me ocurria como hacer para que si se borraba un usuario no desaparezca de todo lados
        //// cuando me comenzo a dar error esta fue la solucion mas congruente y que entendi que me ayudo a armar
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Transaccion>()
        //        .HasOne(t => t.Usuario)
        //        .WithMany()
        //        .HasForeignKey(t => t.usuarioid)
        //        .OnDelete(DeleteBehavior.Restrict);  // 👈 IMPORTANTE

        //    modelBuilder.Entity<Transaccion>()
        //        .HasOne(t => t.Usuario2)
        //        .WithMany()
        //        .HasForeignKey(t => t.usuario2id)
        //        .OnDelete(DeleteBehavior.Restrict);  // 👈 IMPORTANTE

        //    modelBuilder.Entity<Transaccion>()
        //        .Property(t => t.monto)
        //        .HasPrecision(18, 2);

        //    modelBuilder.Entity<Cartera>()
        //        .Property(c => c.resumensaldo)
        //        .HasPrecision(18, 2);

        //    modelBuilder.Entity<Moneda>()
        //        .Property(m => m.cambiodolar)
        //        .HasPrecision(18, 2);
        //}
    }
}
