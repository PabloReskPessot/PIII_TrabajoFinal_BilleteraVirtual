using Microsoft.EntityFrameworkCore;

namespace PIII_TrabajoFinal_BilleteraVirtual.Modelos
{
    public class Transaccion
    {
        public int id {  get; set; }
        public string tipo { get; set; } // ej 
        public decimal monto { get; set; }
        public DateTime fecha { get; set; }
        public int monedaid { get; set; }
        public int usuarioid    { get; set; }
        public int cuentareceptor { get; set; } // originalmente puse usuarioid2 pero lo pense mejor y si transfiero a otro lado fuera del sistema no tendria sentido tener id asi que mejor numero de cuenta y problema resuelto

        public Moneda? Moneda { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
