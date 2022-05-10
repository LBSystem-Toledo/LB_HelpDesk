using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LB_HelpDesk.Data.DTO
{
    [Table("TB_HLP_CategoriaCliente")]
    public class CategoriaCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar descrição da categoria.")]
        [StringLength(50)]
        public string DsCategoria { get; set; } = string.Empty;
    }
}
