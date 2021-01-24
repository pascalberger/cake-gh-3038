using System;
using Cake.Core;
using Cake.DotNetTool.Module;
using Cake.Frosting;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .UseWorkingDirectory("..")
            .UseModule<DotNetToolModule>()
            .UseTool(new Uri("dotnet:?package=GitVersion.Tool&version=5.6.3"))
            .Run(args);
    }
}