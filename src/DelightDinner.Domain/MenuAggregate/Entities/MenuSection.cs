﻿using DelightDinner.Domain.Common.Models;
using DelightDinner.Domain.MenuAggregate.MenuObjects;

namespace DelightDinner.Domain.MenuAggregate.Entities;

public sealed class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _items = new();

    public string Name { get; private set; }
    public string Description { get; private set; }
    public IReadOnlyList<MenuItem> Items => _items.AsReadOnly(); 

    private MenuSection(        
        string name,
        string description,
        List<MenuItem> items,
        MenuSectionId? menuSectionId = null)
        : base(menuSectionId ?? MenuSectionId.CreateUnique())
    {
        Name = name;
        Description = description;
        _items = items;
    }

    public static MenuSection Create(
        string name,
        string description,
        List<MenuItem>? items = null)
    {
        // TODO: enforce invariants
        return new(
            name,
            description,
            items ?? new());
    }

#pragma warning disable CS8618
    private MenuSection()
    {
    }
#pragma warning restore CS8618
}