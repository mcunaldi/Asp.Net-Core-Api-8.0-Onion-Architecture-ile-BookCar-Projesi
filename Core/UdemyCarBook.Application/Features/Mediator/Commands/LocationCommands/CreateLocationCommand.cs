﻿using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands;
public class CreateLocationCommand : IRequest
{
    public string Name { get; set; }
}
