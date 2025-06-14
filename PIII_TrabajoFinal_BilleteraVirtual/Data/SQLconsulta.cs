namespace PIII_TrabajoFinal_BilleteraVirtual.Data
{
    using PIII_TrabajoFinal_BilleteraVirtual.Modelos;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.SqlServer;

    public class SQLconsulta
    {
        public readonly AppDbContext ContextDB;

        public void GuardarMonedas (Moneda moneda)
        {
            ContextDB.Moneda.Add (moneda); // si no entiendo mal, esto atravez de la clase appdbcontext que hace la conexion a la db, usa el dbset moneda para agregar a la tabla mi objeto moneda
            ContextDB.SaveChanges ();
        }


    }
}
