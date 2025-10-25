using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Camila_Reis_Semi_Joias.API.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    public uint IdProduto { get; set; }

    [Display(Name = "Nome Produto", Prompt = "Informe o nome do Produto")]
    [Required(ErrorMessage = "Informe o nome do Produto")]
    [StringLength(30)]
    public string Nome { get; set; }

    [Display(Name = "Descrição", Prompt = "Descreva o Produto")]
    [Required(ErrorMessage = "Descreva o Produto")]
    [StringLength(3000)]
    public string Descricao { get; set; }

    [Display(Prompt = "Informe a Quantidade")]
    [Required(ErrorMessage = "Informe a Quantidade")]
    public uint Quantidade { get; set; }

    [Column(TypeName = "double(12,2)")]
    [Display(Name = "Valor de Custo", Prompt = "Informe o Valor de Custo")]
    [Required(ErrorMessage = "Informe o Valor de Custo")]
    [StringLength(30)]
    public double ValorCusto { get; set; }

    [Column(TypeName = "double(12,2)")]
    [Display(Name = "Valor de Venda", Prompt = "Informe o Valor de Venda")]
    [Required(ErrorMessage = "Informe o Valor de Venda")]
    [StringLength(30)]
    public double ValorVenda { get; set; }

    [Display(Prompt = "Escolha uma Foto")]
    [Required(ErrorMessage = "Escolha uma Foto")]
    [StringLength(300)]
    public string Foto { get; set; }

    public bool Destaque { get; set; }

    public uint CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }
}