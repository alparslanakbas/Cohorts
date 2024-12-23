using System.ComponentModel.DataAnnotations;

namespace Week_14_Identity.API.Dtos
{
    public sealed record Register
    {
        [Required]
        public string UserName { get; init; } = string.Empty;
        [Required]
        public string Email { get; init; } = string.Empty;
        [Required]
        public string Password { get; init; } = string.Empty;
    }
}
