using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int CD_FILME { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NM_FILME{ get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string DS_DESCRICAO { get; set; }
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres")]
        public string DS_GENERO{ get; set; }
        [Range(1,180,ErrorMessage = "Valor entre 1 e 180")]
        public int NR_DURACAO { get; set; }

    }
}
