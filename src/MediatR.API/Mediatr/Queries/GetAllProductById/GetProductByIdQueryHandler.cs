namespace MediatR.API.Mediatr.Queries.GetAllProductById;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdDto>
{
    public Task<GetProductByIdDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        GetProductByIdDto getProductByIdDto = new()
        {
            Name = "Jane Doe"
        };

        return Task.FromResult(getProductByIdDto);

        // Get product from repository
    }
}