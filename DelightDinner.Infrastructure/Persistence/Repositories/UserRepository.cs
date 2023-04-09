﻿using DelightDinner.Application.Common.Interfaces.Persistence;
using DelightDinner.Domain.User;

namespace DelightDinner.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserReposetory
{
    private static readonly List<User> _users = new();

    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }
}