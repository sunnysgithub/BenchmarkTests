namespace BenchmarkTests.SealedClasses;

public sealed class SealedClass : BaseClass
{
    public override void VoidMethod() {}

    public override int IntMethod() => 1;

    public override string StringMethod() => "sealed";
}