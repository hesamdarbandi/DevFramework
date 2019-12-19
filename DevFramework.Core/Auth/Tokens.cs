
using System.Device.Location;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DevFramework.Core.Infrastructure.Model;
using Newtonsoft.Json;

namespace DevFramework.Core.Infrastructure.Auth
{
    public class Tokens
    {
        public static async Task<string> GenerateJwt(ClaimsIdentity identity, IJwtFactory jwtFactory, string name, string userName, JwtIssuerOptions jwtOptions, JsonSerializerSettings serializerSettings)
        {            
            var response = new
            {                                                
                auth_token = await jwtFactory.GenerateEncodedToken(userName, identity),
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            return JsonConvert.SerializeObject(response, serializerSettings);
        }
    }
}