﻿global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Commands;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Models;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Controllers;
global using Microsoft.eShopOnContainers.Services.Ordering.API.Infrastructure.Services;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.BuyerAggregate;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.Events;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.Exceptions;
global using Microsoft.eShopOnContainers.Services.Ordering.Domain.SeedWork;
global using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure.Idempotency;
global using Microsoft.Extensions.Logging;
global using Moq;
global using UnitTest.Ordering;
global using Xunit;