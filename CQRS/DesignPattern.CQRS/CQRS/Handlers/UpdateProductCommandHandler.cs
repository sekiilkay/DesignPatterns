using DesignPattern.CQRS.CQRS.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;
        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.Id);
            values.Name = command.Name;
            values.Price = command.Price;
            values.Stock = command.Stock;
            values.Status = true;
            values.Description = command.Description;
            _context.SaveChanges();
        }
    }
}
