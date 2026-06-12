var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.galaxy_api>("galaxy-api");

builder.Build().Run();
