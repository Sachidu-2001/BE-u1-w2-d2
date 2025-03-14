using System.ComponentModel.DataAnnotations;

namespace WebAppEsame2.Models
{
    public class Tipo_Violazione
    {
        [Key]
        public int Id_Violazione { get; set; }
        [Required]
        public int Descrizione { get; set; }


    }
}
