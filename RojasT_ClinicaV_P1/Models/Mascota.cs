using System;
using System.ComponentModel.DataAnnotations;

namespace RojasT_ClinicaV_P1.Models
{
    public class Mascota
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string Nombre { get; set; }
        public string Raza { get; set; }

        [Range(0, 30)]
        public int Edad { get; set; }
        public string Sexo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        public int PropietarioMascotaId { get; set; }
        public PropietarioMascota Propietario { get; set; }
    }
}
