﻿using DelightDinner.Domain.Common.Models;

namespace DelightDinner.Domain.DinnerAggregate.ValueObjects;

public sealed class Price : ValueObject
{
    public decimal Amount { get; private set; }
    public string Currency { get; private set; }

    private Price(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Price Create(decimal amount, string currency)
    {
        return new(amount, currency);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }

#pragma warning disable CS8618
    private Price()
    {
    }
#pragma warning restore CS8618
}