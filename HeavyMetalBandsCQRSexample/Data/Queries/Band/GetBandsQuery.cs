namespace HeavyMetalBandsCQRSexample.Data.Queries.Band
{
    using MediatR;
    using System.Collections.Generic;

    public record GetBandsQuery() : IRequest<List<BandDto>>;
}
