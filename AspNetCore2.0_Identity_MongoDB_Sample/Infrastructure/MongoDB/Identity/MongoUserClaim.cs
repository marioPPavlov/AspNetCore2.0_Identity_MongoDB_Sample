namespace AspNetCore2_Identity_MongoDB_Sample.Infrastructure.MongoDB.Identity
{
	using System.Security.Claims;

	/// <summary>
	/// A claim that a user possesses.
	/// </summary>
	public class MongoUserClaim
	{
		public MongoUserClaim()
		{
		}

		public MongoUserClaim(Claim claim)
		{
			Type = claim.Type;
			Value = claim.Value;
		}

		/// <summary>
		/// Claim type
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Claim value
		/// </summary>
		public string Value { get; set; }

		public Claim ToSecurityClaim()
		{
			return new Claim(Type, Value);
		}
	}
}