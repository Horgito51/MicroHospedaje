using Hospedaje.Business.DTOs.Hospedaje;

namespace Hospedaje.API.Models.Requests.Internal
{
    public sealed class EstadiaCheckoutRequest
    {
        public string? Observaciones { get; set; }
        public bool RequiereMantenimiento { get; set; }
    }

    public sealed class CargoEstadiaCreateRequest
    {
        public int? IdCatalogo { get; set; }
        public string DescripcionCargo { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal ValorIva { get; set; }
    }

    public static class InternalRequestMapper
    {
        public static CargoEstadiaDTO ToDto(this CargoEstadiaCreateRequest request, int idEstadia) => new()
        {
            IdEstadia = idEstadia,
            IdCatalogo = request.IdCatalogo,
            DescripcionCargo = request.DescripcionCargo,
            Cantidad = request.Cantidad,
            PrecioUnitario = request.PrecioUnitario,
            Subtotal = request.Cantidad * request.PrecioUnitario,
            ValorIva = request.ValorIva,
            TotalCargo = request.Cantidad * request.PrecioUnitario + request.ValorIva,
            EstadoCargo = "PEN",
            CreadoPorUsuario = "Sistema",
            ServicioOrigen = "Hospedaje"
        };
    }
}
