using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace RojasT_ClinicaV_P1.Models
{
    public class PropietarioMascota
    {
        public int Id { get; set; }
        
        [StringLength(20)]    
        public string RojasT_Nombre { get; set; }

        [Range(18, 65)]
        public int Edad { get; set; }

        [Range(20.00, 100.00)]
        public decimal ValorRevision { get; set; }

        public bool EsClienteFrecuente { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
    }
}

