var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.DivisonLoadoutBuilder_ApiService>("apiservice");

builder.AddProject<Projects.DivisonLoadoutBuilder_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
