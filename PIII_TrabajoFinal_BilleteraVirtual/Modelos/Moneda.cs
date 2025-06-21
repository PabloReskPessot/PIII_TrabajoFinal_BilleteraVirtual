using Microsoft.EntityFrameworkCore;

namespace PIII_TrabajoFinal_BilleteraVirtual.Modelos
{
    public class Moneda
    {
        // tenia problemas al crear la base de datos al tener esta entidad por el efecto cascada 
        // prefiero poner el tipo de cuenta que moneda usa y la transaccion que moneda uso y listo
        public int id { get; set; }
        public string nombre { get; set; }
        public string simbolo { get; set; }
        public bool escripto { get; set; }

    }
}
