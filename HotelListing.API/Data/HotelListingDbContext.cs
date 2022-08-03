using System;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels{ get; set; }

        public DbSet<Country> Countries { get; set;  }
    }
}

[AttributeUsage(AttributeTargets.[System.AttributeUsage(AttributeTargets.[System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
public sealed class MyAttribute : Attribute
{
    readonly string positionalString;
    public string PositionalString
    {
        get
        {
            return positionalString;
        }
    }

    public int NamedInt { get; set; }

    public MyAttribute(string positionalString)
    {
        this.positionalString = positionalString;

        // TODO: Implement code here

        throw new NotImplementedException();
    }
}, Inherited = false, AllowMultiple = true)]
public sealed class MyAttribute : Attribute
{
    readonly string positionalString;
    public string PositionalString
    {
        get
        {
            return positionalString;
        }
    }

    public int NamedInt { get; set; }

    public MyAttribute(string positionalString)
    {
        this.positionalString = positionalString;

        // TODO: Implement code here

        throw new NotImplementedException();
    }
}, Inherited = false, AllowMultiple = true)]
public sealed class MyAttribute : Attribute
{
    readonly string positionalString;
    public string PositionalString
    {
        get
        {
            return positionalString;
        }
    }

    public int NamedInt { get; set; }

    public MyAttribute(string positionalString)
    {
        this.positionalString = positionalString;

        // TODO: Implement code here

        throw new NotImplementedException();
    }
}