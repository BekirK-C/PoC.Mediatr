namespace MediatR.API.Mediatr.Queries.GetAllProduct;

public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductDto>>
{
    public Task<List<GetAllProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        GetAllProductDto getProductAllDto = new()
        {
            Id = Guid.NewGuid(),
            Name = "Jane Doe"
        };
        GetAllProductDto getProductAllDto1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "John Doe"
        };

        return Task.FromResult(new List<GetAllProductDto>() { getProductAllDto, getProductAllDto1 });

        // Get all product from repository
    }
}