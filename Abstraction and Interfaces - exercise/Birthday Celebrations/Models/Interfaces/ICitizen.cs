﻿namespace BorderControl.Models.Interfaces
{
    public interface ICitizen : ICreature
    {
        string Name { get; }
        int Age { get; }

        string Id { get; }

        string BirthDate { get; }
    }
}
