using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Queries;
using DesignPattern.Mediator.Mediator.Results;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly AppDbContext _context;
        public GetProductByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);

            return new GetProductByIdQueryResult
            {
                Id = values.Id,
                Name = values.Name,
                Stock = values.Stock
            };
        }
    }
}
