using TraseeMontaneSinaiaAPI.Models;

namespace TraseeMontaneSinaiaAPI.Services;

public static class TraseeMontaneServices
{
    static List<TraseuMontan> TraseeMontane { get; }

    static TraseeMontaneServices()
    {
        TraseeMontane =
        [
            new() {
                Id = 1,
                Name = "Sinaia - Şaua Vârfului cu Dor - Cabana Padina",
                Distance = 14.17,
                DistanceUnit = "KM"
            },
            new() {
                Id = 2,
                Name = "Sinaia - Cabana Omu - Râşnov",
                Distance = 41.34,
                DistanceUnit = "KM"
            },
            new() {
                Id = 3,
                Name = "Sinaia - Vf. Piscul Câinelui",
                Distance = 7.3,
                DistanceUnit = "KM"
            }
        ];
    }

    public static List<TraseuMontan> GetAll() => TraseeMontane;
}