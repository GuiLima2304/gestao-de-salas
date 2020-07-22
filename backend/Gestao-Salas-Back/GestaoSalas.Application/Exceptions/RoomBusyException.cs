using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GestaoSalas.Application.Exceptions
{
    public class RoomBusyException : ApiException
    {
        public RoomBusyException(string message) : base(message)
        {
            Status = (int)HttpStatusCode.BadRequest;
        }
    }
}
