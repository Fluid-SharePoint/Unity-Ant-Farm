using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wizbitz.Pathfinding;

public class AntMemory {

	public Node _home;
	public Hashtable _memoryCellType = new Hashtable();
	public Hashtable _memoryNodeLocation = new Hashtable();
	public List<Node> _knownCells = new List<Node>();
	public Hashtable _routes = new Hashtable();

	public void AddNode(Node node, CellType cellType) {
		// add to hash table Cells first
		if(!_knownCells.Contains(node)) {
			_knownCells.Add(node);
			if(!_memoryNodeLocation.ContainsKey(node)) _memoryNodeLocation.Add(node, new List<CellType>());
			_memoryNodeLocation.Add(node, cellType);
			if(!_memoryCellType.ContainsKey(cellType)) _memoryCellType.Add(cellType, new List<Node>());
			// _memoryCellType[cellType]
		}
	}

	public void RemoveNode(Node node, CellType celltype) {

	}

	public CellType CheckNode(Node node) {
		// Check known cells

		// if known find in hash table
	}

	public void SetHome(Node node) {

	}

	public void AddRoute(Route route) {

	}

	public void RemoveRoute(Route route) {

	}
}
