using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyOrganizator.Control;
using MyOrganizator.Entities;
using MyOrganizator.Modelo.Tables;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace apiJWT3.Controllers
{
  [Route("api/auth")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly UsuarioControl usuarioControl = new UsuarioControl();

    [HttpPost, Route("login")]
    public IActionResult Login([FromBody] LoginRequest user)
    {
      if (user == null)
        return BadRequest("Invalid Client request");

      Usuario usuarioBD = usuarioControl.ObtenerUsuarioPorUsername(user.UserName);

      if (usuarioBD != null && user.UserName == usuarioBD.NombreUsuario && user.Password == usuarioBD.Clave)
      {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, "admin")
                };

        var tokenOptions = new JwtSecurityToken(
            issuer: "https://localhost:5001",
            audience: "https://localhost:5001",
            claims: claims,
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: signingCredentials
        );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        // crea el objeto para la respuesta
        AuthResponse oRta = new AuthResponse();

        oRta.token = tokenString;
        oRta.role = "Desarrollador";
        oRta.nombre = usuarioBD.Alias;

        return Ok(oRta);
      };

      return Unauthorized();
    }

  }
}
