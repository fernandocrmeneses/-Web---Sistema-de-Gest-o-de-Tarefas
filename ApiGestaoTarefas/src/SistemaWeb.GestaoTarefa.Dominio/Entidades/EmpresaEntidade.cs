using SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Dominio.Entidades
{
    public class EmpresaEntidade : Entidade, IAgregadorRaiz
    {
        public string Nome { get; private set; }
        public string CNPJ { get; private set; }

        public ICollection<DepartamentoEntidade> Departamentos { get; private set; }

        protected EmpresaEntidade() { }

        public EmpresaEntidade(string nome, ICollection<DepartamentoEntidade> departamentos)
        {
            Nome = nome;
            Departamentos = departamentos;
        }
    }
}
