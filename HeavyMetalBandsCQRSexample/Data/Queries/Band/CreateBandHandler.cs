namespace HeavyMetalBandsCQRSexample.Data.Queries.Band
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using DbModels;

    public class CreateBandHandler : IRequestHandler<CreateBandCommand, int>
    {
        private readonly DbContext_Write _context;

        public CreateBandHandler(DbContext_Write context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateBandCommand request, CancellationToken cancellationToken)
        {
            var band = new Band
            {
                band_name = request.Name,
                year_created = request.Year
            };

            _context.Bands.Add(band);
            await _context.SaveChangesAsync(cancellationToken);

            return band.id;
        }
    }
}
