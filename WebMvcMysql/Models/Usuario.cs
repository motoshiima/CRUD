using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MYSQL.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Idade")]
        [Column("Idade")]
        public int Idade { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string? Email { get; set; }

    }
}
