﻿namespace Jazani.Application.Admins.Dtos.Periocities
{
    public class NatureDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
