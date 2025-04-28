﻿using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Features.Mediator.Results.FooterAddresResult;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
    {
        private readonly ICarRepository _carRepository;

        public GetCarCountQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
        {
            var values =  _carRepository.GetCarCount();
            return new GetCarCountQueryResult
            {
                CarCount = values,
            };
        }
    }
}
