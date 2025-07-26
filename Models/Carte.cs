using System.ComponentModel.DataAnnotations;

namespace model1.Models
{
    public class Carte
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titlul este obligatorie")]
        public string? Titlu { get; set; }
        [Required(ErrorMessage = "ISBN-ul este obligatoriu")]
        public string? ISBN {  get; set; }
        [Required(ErrorMessage = "Genul este obligatorie")]
        public string? Gen {  get; set; }
        [Required(ErrorMessage = "Autorul este obligatoriu")]
        public int AutorId { get; set; }
        public Autor? Autor { get; set; }
    }
}
