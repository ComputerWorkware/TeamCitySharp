using System.Collections.Generic;

namespace TeamCitySharp.DomainEntities
{
    public class ArtifactDependenciesOfBuild
    {
        public override string ToString()
        {
            return "artifact-dependencies";
        }

        public int Count { get; set; }
        public List<Build> Build { get; set; }
    }
}