using Microsoft.EntityFrameworkCore;

namespace PIII_TrabajoFinal_BilleteraVirtual.Modelos
{
    public class Cartera
    {
        public int id { get; set; }
        public int usuarioid { get; set; }
        public int monedaid { get; set; }
        public decimal saldo { get; set; }

        public Usuario? Usuario { get; set; }
        public Moneda? Moneda { get; set; }
    }
}
