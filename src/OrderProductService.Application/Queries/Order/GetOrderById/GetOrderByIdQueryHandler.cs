using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Order;

namespace OrderProductService.Application.Queries.Order.GetOrderById;

public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, ErrorOr<OrderResponseDto>>
{
    private readonly IOrderRepository _orderRepository;

    public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<ErrorOr<OrderResponseDto>> Handle(GetOrderByIdQuery query, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.GetByIdAsync(query.Id, cancellationToken);

        return order;
    }
}