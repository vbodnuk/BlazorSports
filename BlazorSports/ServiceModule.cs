using System.Reflection;
using F1GrpcServer;
using Grpc.Net.Client;

namespace BlazorSports;

public class ServiceModule : Module
{
    public static void RegisterGrpcService(IServiceCollection services)
    {
        var channel = GrpcChannel.ForAddress("http://localhost:5267");
        var client = new F1Grpc.F1GrpcClient(channel);

        services.AddSingleton(client);
    }
}