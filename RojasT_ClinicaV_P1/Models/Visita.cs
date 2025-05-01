using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RojasT_ClinicaV_P1.Models
{
    public class Visita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese la fecha de visita")]
        [DataType(DataType.Date)]
        public DateTime FechaVisita { get; set; }

        [Range(0, 1000, ErrorMessage = "El valor debe ser positivo")]
        [StringLength(30)]
        public string Tarifa { get; set; }

        public decimal Monto => Tarifa switch
        {
            "vacunación" => 30m,
            "revisión general" => 20m,
            "cirugía" => 100m,
            _ => 0m
        };
        [Required(ErrorMessage = "Ingrese el motivo de la visita")]
        [StringLength(100)]
        public string Motivo { get; set; }

        [Display(Name = "¿Requiere medicación?")]
        public bool RequiereMedicacion { get; set; }

        
        public int MascotaId { get; set; }

        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; }
    }
}
