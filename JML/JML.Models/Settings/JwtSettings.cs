﻿namespace JML.Models.Settings
{
    public class JwtSettings
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Secret { get; set; }
        public int LifeTimeInDays { get; set; }
    }
}
