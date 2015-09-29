namespace Taxation.Models
{
    using System;

    public class InvalidLocationException : Exception
    {
    }

    public enum Location
    {
        Metro,
        NonMetro
    }
}
