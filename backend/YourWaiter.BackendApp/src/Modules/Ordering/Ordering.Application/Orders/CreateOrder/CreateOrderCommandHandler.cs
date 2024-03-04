using MediatR;

namespace Ordering.Application.Orders.CreateOrder;

public record CreateOrderCommand(string OrderName) : IRequest<Unit>;

internal class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Unit>
{
    public Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}