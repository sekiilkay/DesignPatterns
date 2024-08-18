using DesignPattern.Mediator.Mediator.Results;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
