using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GestaoSalas.Application.Exceptions
{
    public class ApiError
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }

        public ApiError(string message, int status)
        {
            this.Message = message;
            this.StatusCode = status;
        }
    }
}
