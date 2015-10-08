using System.Collections.Generic;

namespace TeamCitySharp.DomainEntities
{
	public class SnapshotDependenciesOfBuild
	{
		public override string ToString()
		{
			return "snapshot-dependencies";
		}

        public int Count { get; set; }
		public List<Build> Build { get; set; }
	}
}