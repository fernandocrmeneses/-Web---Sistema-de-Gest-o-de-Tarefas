using SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Dominio.Entidades
{
    public class EmpresaEntidade : Entidade, IAgregadorRaiz
    {
        public string Nome { get; private set; }
        public CnpjEntidade CNPJ { get; private set; }

        protected EmpresaEntidade() { }

        public EmpresaEntidade(string nome)
        {
            Nome = nome;
        }
    }
}
