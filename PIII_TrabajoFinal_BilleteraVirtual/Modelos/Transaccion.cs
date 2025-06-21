using Microsoft.EntityFrameworkCore;
using PIII_TrabajoFinal_BilleteraVirtual.Controllers;

namespace PIII_TrabajoFinal_BilleteraVirtual.Modelos
{
    public class Transaccion
    {
        public int id {  get; set; }
        public string tipo { get; set; } // ej compra / venta
        public int carteraid { get; set; } // numero de cuenta
        public int monedaorigenid { get; set; }
        public int monedadestinoid { get; set; }

        public decimal montoorigen { get; set; } // monto a transferir ej si es de la cuenta pesos y estas comprando dolares seria monto a transferir en pesos
        public decimal montodestino { get; set; }
        public DateTime fecha { get; set; } // fecha dia trans
        public decimal tasacambio { get; set; } // cambio de ese momento, ej si es cuenta pesos cambio de pesos a btc
       

        public Moneda? Monedaorigen { get; set; }
        public Moneda? Monedadestino { get; set; }
        public Cartera? Cartera { get; set; }
    }
}
