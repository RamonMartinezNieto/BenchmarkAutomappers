using AutoMapper;
using BenchmarkMappers.Dtos;
using BenchmarkMappers.Entities;

namespace BenchmarkMappers.Mappers;

public class AutoMapperFactory
{
    private readonly IMapper _mapper;

    public AutoMapperFactory()
    {
        _mapper = GetMapper();
    }

    public static IMapper GetMapper()
    {
        MapperConfiguration conf = new(cfg =>
            {
                cfg.CreateMap<SmallEntity, SmallEntityDto>();
                cfg.CreateMap<MediumEntity, MediumEntityDto>();
                cfg.CreateMap<LargeEntity, LargeEntityDto>();
            });

        return new Mapper(conf);
    }

    public SmallEntityDto AutoMaperToDto(SmallEntity entity)
        => _mapper.Map<SmallEntityDto>(entity);

    public MediumEntityDto AutoMaperToDto(MediumEntity entity)
            => _mapper.Map<MediumEntityDto>(entity);

    public LargeEntityDto AutoMaperToDto(LargeEntity entity)
            => _mapper.Map<LargeEntityDto>(entity);
}
