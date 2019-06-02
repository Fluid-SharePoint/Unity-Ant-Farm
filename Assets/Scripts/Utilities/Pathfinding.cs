using System.Collections;
using System.Collections.Generic;

namespace Wizbitz.Pathfinding
{
    public enum CellType
    {
        RESOURCE,
        HOME,
        WALL,
        EMPTY,
    }

    public class Node
    {
        public int xpos;
        public int ypos;
    }

    public class Route
    {
        public InterestType interestType;
        public int distance;
        public List<Node> route;
    }

	public class Grid {
		// Grid for mapping
	}

	public class Pathfinding {
		public void FindFastestRoute() {
			// Pathfind quickest route
		}
	}

}
