using BenchmarkMappers.Dtos;
using BenchmarkMappers.Entities;
using Mapster;

namespace BenchmarkMappers.Mappers;
public static class MapsterMapper
{
    public static SmallEntityDto MapsterToDto(this SmallEntity entity)
        => entity.Adapt<SmallEntityDto>();

    public static MediumEntityDto MapsterToDto(this MediumEntity entity)
        => entity.Adapt<MediumEntityDto>();

    public static LargeEntityDto MapsterToDto(this LargeEntity entity)
        => entity.Adapt<LargeEntityDto>();
}
