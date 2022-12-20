using CoursWebTokens.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoursWebTokens.Services
{
    public class TokenService : ITokenService
    {
        public string Authenticate(string username, string password)
        {
            // Logique métier pour vérifier l'existence de l'utilisateur

            if (username == "Toto" && password == "TotoPassword")
            {
                // Création d'une instance JWT
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
                {
                    Expires = DateTime.Now.AddDays(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto")), SecurityAlgorithms.HmacSha256Signature),
                    Issuer = "m2i",
                    Audience = "m2i",
                    // Création des roles pour mon application
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("role", "admin")
                    })
                };

                // Création du token avec les params ci-dessus
                SecurityToken token = tokenHandler.CreateToken(securityTokenDescriptor);

                // Retour du Token à l'utilisateur
                return tokenHandler.WriteToken(token);
            }
            return "Erreur d'authentification !";
        }
    }
}
