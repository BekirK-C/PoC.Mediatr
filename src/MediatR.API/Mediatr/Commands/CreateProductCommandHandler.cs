namespace MediatR.API.Mediatr.Commands;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
{
    public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Guid.NewGuid());
        // Send product to repository
    }
}