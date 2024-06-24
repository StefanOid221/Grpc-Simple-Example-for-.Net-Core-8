// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcServiceExample;

var channel = GrpcChannel.ForAddress("http://localhost:32771/");
var client = new Greeter.GreeterClient(channel);

var reply = client.SayHello(new HelloRequest { Name = "World" });
Console.WriteLine($"Greeting: {reply.Message}");
