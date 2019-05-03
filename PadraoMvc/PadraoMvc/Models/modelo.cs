using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PadraoMvc.Models
{
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }
    public class Produto : BaseModel
    {
        public Produto(int movieId, string titulo, string categoria)
        {
            MovieId = movieId;
            Titulo = titulo;
            Categoria = categoria;
        }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Categoria { get; set; }

        public Produto()
        {
        }
    }
}
