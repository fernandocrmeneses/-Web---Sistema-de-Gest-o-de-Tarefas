using SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Dominio.Entidades
{
    public class CnpjEntidade : Entidade
    {
        public string Numero { get; private set; }

        public CnpjEntidade(string numero)
        {
            Numero = numero;
        }
    }
}
