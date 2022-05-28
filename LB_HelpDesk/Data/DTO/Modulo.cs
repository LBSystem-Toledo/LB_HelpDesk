using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LB_HelpDesk.Data.DTO
{
    [Table("TB_HLP_Modulo")]
    public class Modulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar descrição da categoria.")]
        [StringLength(50)]
        public string DsModulo { get; set; } = string.Empty;

    }
}