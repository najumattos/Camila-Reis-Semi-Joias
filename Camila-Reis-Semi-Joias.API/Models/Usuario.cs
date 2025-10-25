using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Camila_Reis_Semi_Joias.API.Models;

[Table("Usuario")]
public class Usuario : IdentityUser
{
    [Key]
    public uint IdUsuario { get; set; }


    [Display(Name = "Nome do Usuário", Prompt = "Informe o nome do Usuário")]
    [Required(ErrorMessage = "Informe o nome do Usuario")]
    [StringLength(30)]
    public string Nome { get; set; }
      
    [Display(Name = "Data De Nascimento", Prompt = "Informe a Data De Nascimento")]
    [Required(ErrorMessage = "Informe a Data De Nascimento")]    
    public DateTime DataNasc { get; set; }

    [Display(Prompt = "Escolha uma Foto")]
    [Required(ErrorMessage = "Escolha uma Foto")]
    [StringLength(300)]
    public string Foto { get; set; }
}
