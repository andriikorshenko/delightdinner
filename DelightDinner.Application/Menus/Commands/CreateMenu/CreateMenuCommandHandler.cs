﻿using DelightDinner.Application.Common.Interfaces.Persistence;
using DelightDinner.Domain.Host.ValueObjects;
using DelightDinner.Domain.Menu;
using DelightDinner.Domain.Menu.Entities;

using ErrorOr;
using MediatR;

namespace DelightDinner.Application.Menus.Commands.CreateMenu;
public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
{
    private readonly IMenuRepository _menuRepository;

    public CreateMenuCommandHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        // Create Menu
        var menu = Menu.Create(
            hostId: HostId.Create(request.HostId),
            name: request.Name,
            description: request.Description,
            sections: request.Sections.ConvertAll(section => MenuSection.Create(
                section.Name,
                section.Description,
                section.Items.ConvertAll(item => MenuItem.Create(
                    item.Name,
                    item.Description)))));

        // Persist Menu
        _menuRepository.Add(menu);

        // Return Menu

        return menu;
    }
}