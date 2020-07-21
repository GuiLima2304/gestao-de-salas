using Gestao_Salas_Back.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_Salas_Back.Controllers
{
    public class DefaultController : BaseController
    {
        public IActionResult Index()
        {
            return Ok("Running...");
        }
    }
}
