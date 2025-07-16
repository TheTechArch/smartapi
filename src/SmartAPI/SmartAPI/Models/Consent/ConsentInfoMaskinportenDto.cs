using Altinn.Authorization.Api.Contracts.Consent;

namespace SmartAPI.Models.Consent
{
    /// <summary>
    /// Represents the consent information for Maskinporten.
    /// </summary>
    public class ConsentInfoMaskinportenDto
    {
        /// <summary>
        /// The unique identifier for the consent. Same ID as concent request.
        /// </summary>
        public string Id { get; set; } = string.Empty;
    }
}
