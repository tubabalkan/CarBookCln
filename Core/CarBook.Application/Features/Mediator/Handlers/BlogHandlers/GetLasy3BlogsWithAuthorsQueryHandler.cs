using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLasy3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLasy3BlogsWithAuthorsQuery, List<GetLasy3BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLasy3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLasy3BlogsWithAuthorsQueryResult>> Handle(GetLasy3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLasy3BlogsWithAuthorsQueryResult
            {
               BlogId = x.BlogId,
               AuthorId = x.AuthorId,
               CategoryId = x.CategoryId,
               CoverImageUrl = x.CoverImageUrl,
               CreatetDate = x.CreatetDate,
               Title = x.Title,
               AuthorName = x.Author.Name
               

            }).ToList();
        }
    }
}
