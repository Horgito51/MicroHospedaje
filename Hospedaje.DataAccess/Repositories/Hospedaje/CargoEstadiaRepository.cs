using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Hospedaje.DataAccess.Context;
using Hospedaje.DataAccess.Entities.Hospedaje;
using Hospedaje.DataAccess.Repositories.Interfaces.Hospedaje;

namespace Hospedaje.DataAccess.Repositories.Hospedaje
{
    public class CargoEstadiaRepository : RepositoryBase<CargoEstadiaEntity>, ICargoEstadiaRepository
    {
        public CargoEstadiaRepository(HospedajeDbContext context) : base(context) { }

        public async Task<CargoEstadiaEntity?> GetByIdAsync(int id, CancellationToken ct = default)
            => await base.GetByIdAsync(id, ct);

        public async Task<CargoEstadiaEntity?> GetByGuidAsync(Guid guid, CancellationToken ct = default)
            => await _dbSet.FirstOrDefaultAsync(c => c.CargoGuid == guid, ct);

        public async Task<IEnumerable<CargoEstadiaEntity>> GetAllAsync(CancellationToken ct = default)
            => await base.GetAllAsync(ct);

        public async Task<CargoEstadiaEntity> AddAsync(CargoEstadiaEntity entity, CancellationToken ct = default)
            => await base.AddAsync(entity, ct);

        public async Task UpdateAsync(CargoEstadiaEntity entity, CancellationToken ct = default)
            => await base.UpdateAsync(entity, ct);

        public async Task AnularAsync(int idCargo, string usuario, CancellationToken ct = default)
        {
            var cargo = await GetByIdAsync(idCargo, ct);
            if (cargo != null && cargo.EstadoCargo == "PEN")
            {
                cargo.EstadoCargo = "ANU";
                cargo.ModificadoPorUsuario = usuario;
                cargo.FechaModificacionUtc = DateTime.UtcNow;
                await UpdateAsync(cargo, ct);
            }
        }
        public async Task<IEnumerable<CargoEstadiaEntity>> GetByEstadiaAsync(int idEstadia, CancellationToken ct = default)
        {
            return await _dbSet.Where(c => c.IdEstadia == idEstadia).ToListAsync(ct);
        }
    }
}