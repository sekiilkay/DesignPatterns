namespace DesignPattern.CQRS.CQRS.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public int Id { get; set; }

        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }
    }
}
