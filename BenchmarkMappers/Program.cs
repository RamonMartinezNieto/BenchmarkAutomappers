using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkMappers.Dtos;
using BenchmarkMappers.Entities;
using BenchmarkMappers.Mappers;
using BenchmarkMappers.Mothers;

namespace BenchmarkMappers;

internal class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BenchmarkClass>();
    }
}

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]
public class BenchmarkClass
{
    private SmallEntity _small = EntityMothers.CreateSmall();
    private MediumEntity _medium = EntityMothers.CreateMedium();
    private LargeEntity _large = EntityMothers.CreateLarge();
    private AutoMapperFactory _mapper = new();

    [Benchmark]
    public void SmallManual()
    {
        SmallEntityDto manualSmall = _small.ManualToDto();
    }

    [Benchmark]
    public void MediumManual()
    {
        MediumEntityDto manualMedium = _medium.ManualToDto();
    }

    [Benchmark]
    public void LargeManual()
    {
        LargeEntityDto manualLarge = _large.ManualToDto();
    }

    [Benchmark]
    public void SmallMapster()
    {
        SmallEntityDto mapsterSmall = _small.MapsterToDto();
    }

    [Benchmark]
    public void MediumMapster()
    {
        MediumEntityDto mapsterMedium = _medium.MapsterToDto();
    }

    [Benchmark]
    public void LargeMapsterl()
    {
        LargeEntityDto mapsterLarge = _large.MapsterToDto();
    }

    [Benchmark]
    public void SmallAutomaper()
    {
        SmallEntityDto mapsterSmall = _mapper.AutoMaperToDto(_small);
    }

    [Benchmark]
    public void MediumAutomaper()
    {
        MediumEntityDto mapsterMedium = _mapper.AutoMaperToDto(_medium);
    }

    [Benchmark]
    public void LargeAutomaper()
    {
        LargeEntityDto mapsterLarge = _mapper.AutoMaperToDto(_large);
    }
}
