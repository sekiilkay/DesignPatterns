using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.Mediator.Commands;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly AppDbContext _context;
        public RemoveProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
