namespace MediatR.API.Mediatr.Queries.GetAllProductById;

public class GetProductByIdQuery : IRequest<GetProductByIdDto>
{
    public Guid Id { get; set; }

    //public GetProductByIdQuery(Guid id)
    //{
    //    Id = id;
    //}
}