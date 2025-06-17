using Microsoft.EntityFrameworkCore;

namespace PIII_TrabajoFinal_BilleteraVirtual.Modelos
{
    public class Transaccion
    {
        public int id {  get; set; }
        public string tipo { get; set; } // ej compra / venta
        public int carteraid { get; set; } // numero de cuenta
        public int monedaid { get; set; } // moneda a comprar ej btc
        public decimal monto { get; set; } // monto a transferir ej si es de la cuenta pesos y estas comprando dolares seria monto a transferir en pesos
        public DateTime fecha { get; set; } // fecha dia trans
        public decimal cambio { get; set; } // cambio de ese momento, ej si es cuenta pesos cambio de pesos a btc
       

        public Moneda? Moneda { get; set; }
        public Cartera? cartera { get; set; }
    }
}
