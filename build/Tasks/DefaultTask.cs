using Cake.Common.Diagnostics;
using Cake.Common.Tools.GitVersion;
using Cake.Core;
using Cake.Frosting;

[TaskName("Default")]
public sealed class DefaultTask : FrostingTask
{
    public override void Run(ICakeContext context)
    {
        // This fails
        // Error: GitVersion: Could not locate executable.
        var version = context.GitVersion();
        context.Information($"Building version {version.SemVer}...");
    }
}