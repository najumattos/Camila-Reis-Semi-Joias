using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Camila_Reis_Semi_Joias.API.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    public uint IdCategoria { get; set; }

    [Display(Prompt = "Informe a Categoria")]
    [Required(ErrorMessage = "Informe a Categoria")]
    [StringLength(50)]
    public string Nome { get; set; }

    [Display(Prompt = "Escolha uma Foto")]
    [StringLength(300)]
    public string Foto { get; set; }

    [Display(Prompt="Informe uma Cor")]
    [StringLength(26)]
    public string Cor { get; set; }

}