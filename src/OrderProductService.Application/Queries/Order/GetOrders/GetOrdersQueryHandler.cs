using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Queries.Product.GetProductById;
using OrderProductService.Application.Responses.Categories;
using OrderProductService.Application.Responses.Orders;

namespace OrderProductService.Application.Queries.Order.GetOrders;

public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, ErrorOr<List<OrderResponseDto>>>
{
    private readonly IOrderRepository _orderRepository;

    public GetOrdersQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<ErrorOr<List<OrderResponseDto>>> Handle(GetOrdersQuery query, CancellationToken cancellationToken)
    {
        var orders = await _orderRepository.GetAllAsync(cancellationToken);

        return orders.ToList();
    }
}