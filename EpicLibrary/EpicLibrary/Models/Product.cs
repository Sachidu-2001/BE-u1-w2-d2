using System.ComponentModel.DataAnnotations;
using System.Reflection;


namespace EpicLibrary.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength]
        public string Title { get; set; }
        [Required]
        [MaxLength]
        public string Autore {  get; set; }
        [Required]
        [MaxLength]
        public string Genere { get; set; }
        [Required]
        [MaxLength]
        public string Disponibilità { get; set; }






    }
}
