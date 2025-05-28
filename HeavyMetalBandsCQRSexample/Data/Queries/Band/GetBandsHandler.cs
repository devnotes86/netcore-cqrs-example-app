namespace HeavyMetalBandsCQRSexample.Data.Queries.Band
{
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks; 

    public class GetProductsHandler : IRequestHandler<GetBandsQuery, List<BandDto>>
    {
        private readonly DbContext_Read _context;

        public GetProductsHandler(DbContext_Read context)
        {
            _context = context;
        }

        public async Task<List<BandDto>> Handle(GetBandsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Bands
                .AsNoTracking()
                .Select(p => new BandDto(p.id, p.band_name, p.year_created))
                .ToListAsync(cancellationToken);
        }
    }
}
