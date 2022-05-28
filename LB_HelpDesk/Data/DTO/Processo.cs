using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LB_HelpDesk.Data.DTO
{
    [Table("TB_HLP_Processo")]
    public class Processo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("IdModulo")]
        public Modulo Modulo { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar descrição da categoria.")]
        [StringLength(50)]
        public string DsProcesso { get; set; } = string.Empty;
        
        [StringLength(2048)]
        public string Complementoo { get; set; } = string.Empty;

    }
}