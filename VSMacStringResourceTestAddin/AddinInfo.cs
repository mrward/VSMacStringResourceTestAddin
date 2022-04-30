
using System.Runtime.Versioning;
using Mono.Addins;

// Need to fix CA1416 build warning.
// This call site is reachable on all platforms. 'NSLayoutConstraint.Active' is only supported on: 'ios' 10.0 and later,
// 'maccatalyst' 10.0 and later, 'macOS/OSX' 10.14 and later, 'tvos' 10.0 and later. (CA1416))
// https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1416
[assembly: SupportedOSPlatform ("macos10.15")]

[assembly: Addin (
	"StringResourceTest",
	Namespace = "MonoDevelop",
	Version = "0.1",
	Category = "IDE extensions")]

[assembly: AddinName ("StringResourceTest")]
[assembly: AddinDescription ("StringResourceTest")]

[assembly: AddinDependency ("Core", "17.0")]
[assembly: AddinDependency ("Ide", "17.0")]

