using System.Threading.Tasks;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace performance;
public class Program
{
    public static async Task Main(string[] args)
    {
#if DEBUG
        var descriptions = new Descriptions();

        await descriptions.GetAllDescriptions();
        await descriptions.PetStoreYaml();
        await descriptions.PetStoreJson();
        await descriptions.GHESYaml();
        await descriptions.GHESJson();
#else
        var config = DefaultConfig.Instance;
        BenchmarkRunner.Run<Descriptions>(config, args);
        ////BenchmarkRunner.Run<EmptyModels>(config, args);
#endif

        await Task.CompletedTask;
    }
}
