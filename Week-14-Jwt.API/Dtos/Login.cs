﻿using Microsoft.Build.Framework;

namespace Week_14_JWT.API.Dtos
{
    public sealed record Login
    {
        [Required]
        public string Email { get; init; } = string.Empty;
        [Required]
        public string Password { get; init; } = string.Empty;
    }
}