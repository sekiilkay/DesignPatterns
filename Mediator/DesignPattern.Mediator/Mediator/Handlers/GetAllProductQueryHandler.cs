using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Queries;
using DesignPattern.Mediator.Mediator.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly AppDbContext _context;
        public GetAllProductQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Category = x.Category,
                Stock = x.Stock,
                StockType = x.StockType
            }).AsNoTracking().ToListAsync();
        }
    }
}
