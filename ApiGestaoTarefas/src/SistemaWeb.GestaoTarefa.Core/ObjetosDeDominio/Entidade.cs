using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio
{
    public class Entidade
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
