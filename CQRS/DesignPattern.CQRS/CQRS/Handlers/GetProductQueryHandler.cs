using DesignPattern.CQRS.CQRS.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;
        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Id = x.Id,
                Price = x.Price,
                Name = x.Name,
                Stock = x.Stock,
            }).ToList();

            return values;
        }
    }
}
