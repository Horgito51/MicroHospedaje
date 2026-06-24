namespace Hospedaje.Contracts.Events;

public sealed record CheckInRealizadoIntegrationEvent : IntegrationEventBase
{
    public override string EventType => "hospedaje.checkin.realizado";
    public Guid EstadiaGuid { get; init; }
    public Guid ReservaGuid { get; init; }
    public Guid SucursalGuid { get; init; }
    public DateTime FechaCheckInUtc { get; init; }
    public IReadOnlyList<Guid> HabitacionGuids { get; init; } = Array.Empty<Guid>();
}

