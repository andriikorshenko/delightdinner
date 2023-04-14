﻿using DelightDinner.Domain.Bill;
using DelightDinner.Domain.Menu;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DelightDinner.Infrastructure.Persistence;

public class DelightDinnerDbContext : DbContext
{
    public DelightDinnerDbContext(DbContextOptions<DelightDinnerDbContext> options)
        : base(options) 
    { 
    }

    DbSet<Menu> Menus { get; set; } = null!;

    DbSet<Bill> Bills { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(DelightDinnerDbContext).Assembly);

        modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetProperties())
            .Where(p => p.IsPrimaryKey())
            .ToList()
            .ForEach(p => p.ValueGenerated = ValueGenerated.Never);

        base.OnModelCreating(modelBuilder);
    }
}