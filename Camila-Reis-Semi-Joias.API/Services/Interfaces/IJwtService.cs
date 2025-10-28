using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Camila_Reis_Semi_Joias.API.Models;

namespace Camila_Reis_Semi_Joias.API.Services.Interfaces
{
    public interface IJwtService
    {
         string GenerateToken(Usuario user);
    }
}