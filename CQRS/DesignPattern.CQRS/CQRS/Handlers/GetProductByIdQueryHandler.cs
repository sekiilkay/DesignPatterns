using DesignPattern.CQRS.CQRS.Queries;
using DesignPattern.CQRS.CQRS.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;
        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult
            {
                Name = values.Name,
                Stock = values.Stock,
                Price = values.Price,
                Id = values.Id
            };
        }
    }
}
