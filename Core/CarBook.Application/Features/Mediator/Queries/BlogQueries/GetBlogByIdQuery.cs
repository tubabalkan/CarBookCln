﻿using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Features.Mediator.Results.LocationResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
    {
        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
