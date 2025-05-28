namespace HeavyMetalBandsCQRSexample.Data.Queries.Band
{
    using MediatR;

    public record CreateBandCommand(string Name, int Year) : IRequest<int>;
}
