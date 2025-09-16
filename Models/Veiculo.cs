using System;

namespace ParkingSystemApi.Models
{
    public class Veiculo
    {
        public string Placa { get; set; } = string.Empty;
        public DateTime Entrada { get; set; } = DateTime.Now;
    }
}
