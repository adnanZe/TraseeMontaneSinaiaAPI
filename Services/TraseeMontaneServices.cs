using TraseeMontaneSinaiaAPI.Models;

namespace TraseeMontaneSinaiaAPI.Services;

public static class TraseeMontaneServices
{
    static List<TraseuMontan> TraseeMontane { get; }

    static int nextId = 3;
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

    public static TraseuMontan? Get(int id) => TraseeMontane.FirstOrDefault(p => p.Id == id);

    public static void Add(TraseuMontan traseuMontan)
    {
        traseuMontan.Id = nextId++;
        TraseeMontane.Add(traseuMontan);
    }

    public static void Delete(int id)
    {
        var traseuMontan = Get(id);
        if (traseuMontan is null)
            return;

        TraseeMontane.Remove(traseuMontan);
    }

    public static void Update(TraseuMontan traseuMontan)
    {
        var index = TraseeMontane.FindIndex(p => p.Id == traseuMontan.Id);
        if (index == -1)
            return;

        TraseeMontane[index] = traseuMontan;
    }
}
