﻿using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Features.Mediator.Results.LocationResult;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarsPricingsWithCars();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
               Amount = x.Amount,
               Brand=x.Car.Brand.Name,
               CarPricingId =x.CarPricingId,
               CoverImageUrl=x.Car.CoverImgUrl,
               Model=x.Car.Model

            }).ToList();
        }
    }
}
