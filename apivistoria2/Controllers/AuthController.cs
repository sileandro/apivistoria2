using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apivistoria2.Models;
using apivistoria2.Services.Internal.Interfaces;
using apivistoria2.Services.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apivistoria2.Controllers
{
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Autenticar")]
        public async Task<IActionResult> Autenticar([FromBody] LoginUser loginuser)
        {
            var user = await _authService.Login(loginuser.Login, loginuser.Senha);
            if (user != null)
            {
                var token = Utils.GenerateToken(user);
                return Ok(new {
                                user.CpfNavigation.Nome,
                                user.CpfNavigation.Abreviacao,
                                user.Perfil,
                                token
                              });
            }
            else return BadRequest("Usuário ou senha inválidos");
        }

        [HttpPost("teste")]
        [Authorize(Roles = "Vistoriador")]
        public async Task<IActionResult> teste([FromBody] LoginUser loginuser)
        {
            var user = await _authService.Login(loginuser.Login, loginuser.Senha);
            if (user != null)
            {
                var token = Utils.GenerateToken(user);
                return Ok(new
                {
                    user.CpfNavigation.Nome,
                    user.CpfNavigation.Abreviacao,
                    user.Perfil,
                    token
                });
            }
            else return BadRequest("Usuário ou senha inválidos");
        }
    }
}
