using System;
using System.ComponentModel.DataAnnotations;

namespace CursoMV.Models
{
    public class Produto
    {

        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Range(1, 100, ErrorMessage = "Valor tem que está entra 1 e 100")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

    }
}
