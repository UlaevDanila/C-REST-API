namespace OrderProductService.Domain.Common;

public class Entity
{
    public Guid Id { get; } = new Guid();
    
#pragma warning disable CS8618
    protected Entity() { }
#pragma warning restore CS8618
}