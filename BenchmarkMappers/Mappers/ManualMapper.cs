using BenchmarkMappers.Dtos;
using BenchmarkMappers.Entities;

namespace BenchmarkMappers.Mappers;

public static class ManualMapper
{
    public static SmallEntityDto ManualToDto(this SmallEntity entity) =>
        new()
        {
            One = entity.One,
            Two = entity.Two,
            Three = entity.Three,
            Four = entity.Four,
            Five = entity.Five
        };

    public static MediumEntityDto ManualToDto(this MediumEntity entity) =>
        new()
        {
            One = entity.One,
            Two = entity.Two,
            Three = entity.Three,
            Four = entity.Four,
            Five = entity.Five,
            Six = entity.Six,
            Seven = entity.Seven,
            Eight = entity.Eight,
            Nine = entity.Nine,
            Ten = entity.Ten
        };


    public static LargeEntityDto ManualToDto(this LargeEntity entity) =>
        new()
        {
            One = entity.One,
            Two = entity.Two,
            Three = entity.Three,
            Four = entity.Four,
            Five = entity.Five,
            Six = entity.Six,
            Seven = entity.Seven,
            Eight = entity.Eight,
            Nine = entity.Nine,
            Ten = entity.Ten,
            Eleven = entity.Eleven,
            Twelve = entity.Twelve,
            Thirteen = entity.Thirteen,
            Fourteen = entity.Fourteen,
            Fifteen = entity.Fifteen
        };
}
