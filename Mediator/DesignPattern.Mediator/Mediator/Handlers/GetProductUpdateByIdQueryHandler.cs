using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Queries;
using DesignPattern.Mediator.Mediator.Results;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIdQuery, UpdateProductByIdQueryResult>
    {
        private readonly AppDbContext _context;
        public GetProductUpdateByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);

            return new UpdateProductByIdQueryResult
            {
                Id = values.Id,
                Category = values.Category,
                Stock = values.Stock,
                Name = values.Name,
                StockType = values.StockType,
                Price = values.Price
            };
        }
    }
}
