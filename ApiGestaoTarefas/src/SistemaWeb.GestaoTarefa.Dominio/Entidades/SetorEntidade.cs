using SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio;
using System;

namespace SistemaWeb.GestaoTarefa.Dominio.Entidades
{
    public class SetorEntidade : Entidade
    {
        public string Nome { get; set; }

        public DepartamentoEntidade Departamento { get; set; }

        public Guid IdDepartamento { get; set; }
    }
}
