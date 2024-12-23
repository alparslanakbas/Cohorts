namespace Week_14_JWT.API.Dtos
{
    public sealed record CustomTokenOptions
    {
        public List<string> Audience { get; set; } = new();
        public string Issuer { get; set; } = string.Empty;
        public int AccessTokenExpiration { get; set; }
        public int RefreshTokenExpiration { get; set; }
        public string SecurityKey { get; set; } = string.Empty;
    }
}
