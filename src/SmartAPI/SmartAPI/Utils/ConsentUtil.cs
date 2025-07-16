using SmartAPI.Models.Consent;
using System.Security.Claims;
using System.Text.Json;

namespace SmartAPI.Utils
{
    /// <summary>
    /// Util class for systemuserAPI 
    /// </summary>
    public static class ConsentUtil
    {

        /// <summary>
        /// Gets the users id
        /// </summary>
        /// <param name="context">the http context</param>
        /// <returns>the logged in system users id</returns>

        public static Rootobject? GetConsentInfo(ClaimsPrincipal claimsprincipal)
        {
            var claim = claimsprincipal?.Claims.FirstOrDefault(c => c.Type.Equals("authorization_details"));
            if (claim != null)
            {
                string jwtSystemUSerClaim = claim.Value;

                Rootobject? consentInfo = JsonSerializer.Deserialize<Rootobject>(jwtSystemUSerClaim);

                return consentInfo;
            }

            return null;
        }
     
    }
}
