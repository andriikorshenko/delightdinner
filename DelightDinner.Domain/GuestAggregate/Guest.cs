﻿using DelightDinner.Domain.Bill.ValueObjects;
using DelightDinner.Domain.Common.Models;
using DelightDinner.Domain.Common.ValueObjects;
using DelightDinner.Domain.Dinner.ValueObjects;
using DelightDinner.Domain.Guest.Entities;
using DelightDinner.Domain.Guest.ValueObjects;
using DelightDinner.Domain.MenuReview.ValueObjects;
using DelightDinner.Domain.User.ValueObjects;

namespace DelightDinner.Domain.Guest;

public class Guest : AggregateRoot<GuestId>
{
    private readonly List<DinnerId> _upcommingDinnerIds = new();
    private readonly List<DinnerId> _pastDinnerIds = new();
    private readonly List<DinnerId> _pendingDinnerIds = new();
    private readonly List<MenuReviewId> _menuReviewIds = new();
    private readonly List<GuestRating> _ratings = new();
    private readonly List<BillId> _billIds = new();

    public string FirstName { get; }
    public string LastName { get; }
    public Uri ProfileImage { get; }
    public UserId UserId { get; }

    public IReadOnlyList<DinnerId> UpcommingDinnersIds => _upcommingDinnerIds.AsReadOnly();
    public IReadOnlyList<DinnerId> PastDinnersIds => _pastDinnerIds.AsReadOnly();
    public IReadOnlyList<DinnerId> PendingDinnersIds => _pendingDinnerIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
    public IReadOnlyList<GuestRating> Ratings => _ratings.AsReadOnly();
    public IReadOnlyList<BillId> BillIds => _billIds.AsReadOnly();

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Guest(
        string firstName,
        string lastName,
        UserId userId,
        Uri profileImage,
        GuestRating? guestRating = null,
        GuestId? guestId = null)
        : base(guestId ?? GuestId.CreateUnique())
    {        
        FirstName = firstName;
        LastName = lastName;
        UserId = userId;
        ProfileImage = profileImage;
    }

    public static Guest Create(        
        string firstName,
        string lastName,
        UserId userId,
        Uri profileImage)
    {
        // TODO: enforce invariants
        return new(
            firstName,
            lastName,
            userId,
            profileImage);
    }
}