using DesignPattern.Mediator.Mediator.Results;
using MediatR;

namespace DesignPattern.Mediator.Mediator.Queries
{
    public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>>
    {
        
    }
}
