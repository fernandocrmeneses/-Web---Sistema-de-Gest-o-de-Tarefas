using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaWeb.GestaoTarefa.Core.ObjetosDeDominio
{
    public class ExcecoesDominio : Exception
    {
        public ExcecoesDominio()
        { }

        public ExcecoesDominio(string message) : base(message)
        { }

        public ExcecoesDominio(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
