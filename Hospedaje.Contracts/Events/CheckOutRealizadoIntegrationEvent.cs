namespace Hospedaje.Contracts.Events;

public sealed record CheckOutRealizadoIntegrationEvent : IntegrationEventBase
{
    public override string EventType => "hospedaje.checkout.realizado";
    public Guid EstadiaGuid { get; init; }
    public Guid ReservaGuid { get; init; }
    public Guid SucursalGuid { get; init; }
    public DateTime FechaCheckOutUtc { get; init; }
    public decimal TotalCargos { get; init; }
    public string Moneda { get; init; } = "USD";
    public IReadOnlyList<Guid> HabitacionGuids { get; init; } = Array.Empty<Guid>();
}

