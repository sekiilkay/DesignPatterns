using DesignPattern.CQRS.CQRS.Queries;
using DesignPattern.CQRS.CQRS.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class GetProductUpdateQueryHandler
    {
        private readonly Context _context;
        public GetProductUpdateQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var values = _context.Products.Find(query.Id);

            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                Id = values.Id,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
            };
        }
    }
}
