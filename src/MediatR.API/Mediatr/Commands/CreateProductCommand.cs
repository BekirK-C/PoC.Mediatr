namespace MediatR.API.Mediatr.Commands;

public class CreateProductCommand : IRequest<Guid>
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
}