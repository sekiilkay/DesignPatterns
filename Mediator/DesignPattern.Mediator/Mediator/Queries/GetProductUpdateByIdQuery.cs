using DesignPattern.Mediator.Mediator.Results;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Queries
{
    public class GetProductUpdateByIdQuery : IRequest<UpdateProductByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }
    }
}
