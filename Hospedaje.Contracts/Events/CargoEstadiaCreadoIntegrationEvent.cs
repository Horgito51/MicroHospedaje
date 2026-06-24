namespace Hospedaje.Contracts.Events;

public sealed record CargoEstadiaCreadoIntegrationEvent : IntegrationEventBase
{
    public override string EventType => "hospedaje.cargo_estadia.creado";
    public Guid CargoGuid { get; init; }
    public Guid EstadiaGuid { get; init; }
    public Guid ReservaGuid { get; init; }
    public string Concepto { get; init; } = string.Empty;
    public decimal Cantidad { get; init; }
    public decimal PrecioUnitario { get; init; }
    public decimal TotalCargo { get; init; }
    public string Moneda { get; init; } = "USD";
    public DateTime FechaCargoUtc { get; init; }
}

