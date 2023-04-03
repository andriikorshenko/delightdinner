﻿using DelightDinner.Domain.Common.Models;
using DelightDinner.Domain.Dinner.ValueObjects;
using DelightDinner.Domain.Guest.ValueObjects;
using DelightDinner.Domain.Menu.MenuObjects;

namespace DelightDinner.Domain.MenuReview.ValueObjects;

public sealed class MenuReviewId : ValueObject
{
    public string Value { get; }

    private MenuReviewId(MenuId menuId, DinnerId dinnerId, GuestId guestId)
    {
        Value = $"MenuReview_{menuId.Value}_{dinnerId.Value}_{guestId.Value}";
    }

    private MenuReviewId(string value)
    {
        Value = value;
    }

    public static MenuReviewId Create(MenuId menuId, DinnerId dinnerId, GuestId guestId)
    {
        return new MenuReviewId(menuId, dinnerId, guestId);
    }
    public static MenuReviewId Create(string value)
    {
        return new MenuReviewId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}