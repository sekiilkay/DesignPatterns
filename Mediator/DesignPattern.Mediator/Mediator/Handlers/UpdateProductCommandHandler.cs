using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly AppDbContext _context;
        public UpdateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            values.Name = request.Name;
            values.Stock = request.Stock;
            values.StockType = request.StockType;
            values.Price = request.Price;
            values.Category = request.Category;
            await _context.SaveChangesAsync();
        }
    }
}
