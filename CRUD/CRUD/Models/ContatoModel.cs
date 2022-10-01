using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
        [Table("Contatos")]
    public class ContatoModel
    {
        [Column("Id")]
        [Display(Name = "Id")]
        [Key]public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public  string Email { get; set; }

        [Column("Numero")]
        [Display(Name = "Número")]
        public string Numero { get; set; }
    }
}
