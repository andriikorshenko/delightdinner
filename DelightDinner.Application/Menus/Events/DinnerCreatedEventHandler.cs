﻿using DelightDinner.Application.Common.Interfaces.Persistence;
using DelightDinner.Domain.DinnerAggregate.Events;

using MediatR;

namespace DelightDinner.Application.Menus.Events;

public class DinnerCreatedEventHandler : INotificationHandler<DinnerCreated>
{
    private readonly IMenuRepository _menuRepository;

    public DinnerCreatedEventHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task Handle(DinnerCreated notification, CancellationToken cancellationToken)
    {
        if (await _menuRepository.)
        {

        }
    }
}