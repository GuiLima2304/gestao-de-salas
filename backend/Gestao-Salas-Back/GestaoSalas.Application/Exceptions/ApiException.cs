using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GestaoSalas.Application.Exceptions
{
    public class ApiException : Exception
    {
        public int Status { get; set; }

        public ApiException(string message) : base(message)
        {
        }
    }
}
