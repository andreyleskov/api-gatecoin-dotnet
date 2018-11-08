using System.Reflection;

namespace Gatecoin.Streaming.Common.Version
{
    public class VersionedAssemblyInfo : IAssemblyVersion
    {
        public VersionedAssemblyInfo() : this(Assembly.GetEntryAssembly())
        {
        }

        public VersionedAssemblyInfo(Assembly assembly)
        {
            Version = assembly.GetName().Version.ToString();
            InformationVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            FileVersion = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;
        }
        /// <summary>
        /// General version of an Assembly, the same as package version. Using Semver2.0.0
        /// Format: MAJOR.MINOR.PATCH[-QualityStage][+BuildMetadata]
        /// if QualityStage is presented, binarieas are assumed to be a preview version, not yet ready for the release
        /// Usually it will looks like:
        /// -alfa
        /// -beta
        /// -preview
        /// -rc
        /// BuildMetadata can be presented in format [Branch.Build]
        /// Branch is git branch
        /// Build is a build number from CI
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// The Product version of the assembly.
        /// This is the version you would use when talking to customers or for display on your website.
        /// This version can be a string, like '1.0 Release Candidate'.
        /// Is a generalization over the Version by not including the Patch and changing the suffix to a Release
        /// Format: MAJOR.MINOR-QualityStageFullName
        /// where QualityStageFullName is a full name of QualityStage from Version
        /// </summary>

        public string InformationVersion { get; }
        /// <summary>
        /// This is the version number given to a file as in file system.
        /// It is displayed by Windows Explorer.
        /// It’s never used by .NET framework or runtime for referencing.
        /// It is a detalization over the Version by including a build number
        /// Format: MAJOR.MINOR.PATCH.Build
        /// Where Build is a number from CI server
        /// </summary>
        public string FileVersion { get; }
    }
}
