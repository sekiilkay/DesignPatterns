using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly AppDbContext _context;
        public CreateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _context.Products.AddAsync(new Product
            {
                Price = request.Price,
                Name = request.Name,
                Category = request.Category,
                Stock = request.Stock,
                StockType = request.StockType,
            });
            await _context.SaveChangesAsync();
        }
    }
}
