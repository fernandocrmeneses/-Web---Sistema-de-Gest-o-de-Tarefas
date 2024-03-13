using SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio;
using System;
using System.Collections.Generic;

namespace SistemaWeb.GestaoTarefa.Dominio.Entidades
{
    public class GestorEntidade : Entidade
    {
        public int CodigoGestor { get; private set; }

        public UsuarioEntidade Usuario { get; private set; }

        public ICollection<DepartamentosGestoresEntidade> DepartamentoGestores { get; private set; }



        public GestorEntidade(int codigoGestor, UsuarioEntidade usuario, ICollection<DepartamentosGestoresEntidade> departamentosGestores)
        {
            CodigoGestor = codigoGestor;
            Usuario = usuario;
            DepartamentoGestores = departamentosGestores;
        }
    }
}