using SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Dominio.Entidades
{
    public class DepartamentosGestoresEntidade : Entidade
    {
        public DepartamentoEntidade Departamento { get; private set; }
        public GestorEntidade Gestor { get; private set; }

        public Guid IdDepartamento { get; private set; }
        public Guid IdGestor { get; private set; }

        public DepartamentosGestoresEntidade(DepartamentoEntidade departamento, GestorEntidade gestor, Guid idDepartamento, Guid idGestor)
        {
            Departamento = departamento;
            Gestor = gestor;
            IdDepartamento = idDepartamento;
            IdGestor = idGestor;
        }
    }
}
