using MediatR;

namespace Ordering.Application.Orders.CreateOrder;

public record CreateOrderCommand(string OrderName) : IRequest<Unit>;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Unit>
{
    public Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var orderName = request.OrderName;
        return Task.FromResult(Unit.Value);
    }
}