using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Orders;

namespace OrderProductService.Application.Queries.Order.GetOrdersByStatus;

public class GetOrdersByStatusQueryHandler : IRequestHandler<GetOrdersByStatusQuery, ErrorOr<List<OrderResponseDto>>>
{
    private readonly IOrderRepository _orderRepository;

    public GetOrdersByStatusQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<ErrorOr<List<OrderResponseDto>>> Handle(GetOrdersByStatusQuery query,
        CancellationToken cancellationToken)
    {
        var orders = await _orderRepository.GetByStatusAsync(query.Status, cancellationToken);

        return orders.ToList();
    }
}