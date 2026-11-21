using System.ComponentModel.DataAnnotations;

namespace SistemaInscricaoCursosBlazor.Components.Models;

public class InscricaoModel
{
    [Required(ErrorMessage = "Informe seu nome.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe seu e-mail.")]
    [EmailAddress(ErrorMessage = "Informe um endereço de e-mail válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe sua idade.")]
    [Range(16, 100, ErrorMessage = "A idade deve estar entre 16 e 100 anos.")]
    public int Idade { get; set; }

    [Required(ErrorMessage = "Selecione um curso.")]
    public string CursoId { get; set; } = string.Empty;
}
