using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTests.SealedClasses;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class BenchmarkTest
{
    private readonly BaseClass base_normalClass = new NormalClass();
    private readonly BaseClass base_sealedClass = new SealedClass();
    private readonly NormalClass normalClass = new();
    private readonly SealedClass sealedClass = new();

    [Benchmark]
    public void RunBNC_VoidMethod() => base_normalClass.VoidMethod();
    
    [Benchmark]
    public void RunBSC_VoidMethod() => base_sealedClass.VoidMethod();
    
    [Benchmark]
    public void RunNC_VoidMethod() => normalClass.VoidMethod();
    
    [Benchmark]
    public void RunSC_VoidMethod() => sealedClass.VoidMethod();
    
    [Benchmark]
    public int RunBNC_IntMethod() => base_normalClass.IntMethod();
    
    [Benchmark]
    public int RunBSC_IntMethod() => base_sealedClass.IntMethod();
    
    [Benchmark]
    public int RunNC_IntMethod() => normalClass.IntMethod();
    
    [Benchmark]
    public int RunSC_IntMethod() => sealedClass.IntMethod();
    
    [Benchmark]
    public string RunBNC_StringMethod() => base_normalClass.StringMethod();
    
    [Benchmark]
    public string RunBSC_StringMethod() => base_sealedClass.StringMethod();
    
    [Benchmark]
    public string RunNC_StringMethod() => normalClass.StringMethod();
    
    [Benchmark]
    public string RunSC_StringMethod() => sealedClass.StringMethod();

    [Benchmark]
    public string RunNC_StaticMethod() => NormalClass.StaticMethod();

    [Benchmark]
    public string RunSC_StaticMethod() => SealedClass.StaticMethod();
}