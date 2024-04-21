using BenchmarkMappers.Entities;

namespace BenchmarkMappers.Mothers;

public static class EntityMothers
{
    public static SmallEntity CreateSmall() =>
        new()
        {
            One = "One",
            Two = 2,
            Three = 3.3d,
            Four = 4.4f,
            Five = '5'
        };

    public static MediumEntity CreateMedium() =>
        new()
        {
            One = "One",
            Two = 2,
            Three = 3.3d,
            Four = 4.4f,
            Five = '5',
            Six = "Six",
            Seven = 7,
            Eight = 8.8d,
            Nine = 9.9f,
            Ten = 'T'
        };

    public static LargeEntity CreateLarge() =>
        new()
        {
            One = "One",
            Two = 2,
            Three = 3.3d,
            Four = 4.4f,
            Five = '5',
            Six = "Six",
            Seven = 7,
            Eight = 8.8d,
            Nine = 9.9f,
            Ten = 'T',
            Eleven = "Eleven",
            Twelve = 12,
            Thirteen = 13.13d,
            Fourteen = 14.14f,
            Fifteen = 'F'
        };
}
