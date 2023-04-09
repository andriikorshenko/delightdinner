﻿using DelightDinner.Domain.Common.Models;
using DelightDinner.Domain.Common.ValueObjects;
using DelightDinner.Domain.Dinner.ValueObjects;
using DelightDinner.Domain.Host.ValueObjects;
using DelightDinner.Domain.Menu.MenuObjects;
using DelightDinner.Domain.User.ValueObjects;

namespace DelightDinner.Domain.Host;

public class Host : AggregateRoot<HostId>
{
    private readonly List<MenuId> _menuId = new();
    private readonly List<DinnerId> _dinnerId = new();

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Uri ProfileImage { get; private set; }
    public AverageRating AverageRating { get; private set; }
    public UserId UserId { get; private set; }

    public IReadOnlyList<DinnerId> DinnerIds => _dinnerId.AsReadOnly();
    public IReadOnlyList<MenuId> MenuIds => _menuId.AsReadOnly();

    public DateTime CreatedDateTime { get; private set; }
    public DateTime UpdatedDateTime { get; private set; }

    private Host(
        HostId hostId,
        UserId userId,
        string firstName,
        string lastName,
        Uri profileImage,
        AverageRating averageRating)
        : base(hostId ?? HostId.Create(userId))
    {
        FirstName = firstName;
        LastName = lastName;
        ProfileImage = profileImage;
        UserId = userId;
        AverageRating = averageRating;
    }

    public static Host Create(
        UserId userId,
        string firstName,
        string lastName,
        Uri profileImage)
    {
        return new(
            HostId.Create(userId),
            userId,
            firstName,
            lastName,
            profileImage,
            AverageRating.CreateNew());
    }

#pragma warning disable CS8618
    private Host()
    {
    }
#pragma warning restore CS8618
}