using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntBrain : MonoBehaviour {

	private AntMemory _memory;
	private AntMove _move;

	// Use this for initialization
	void Start () {
		_memory = GetComponent<AntMemory>();
		_move = GetComponent<AntMove>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void _AnalyzeSurroundings() {
		RaycastHit2D hitUp = Physics2D.Raycast(transform.position, Vector2.up, 1);
		RaycastHit2D hitDown = Physics2D.Raycast(transform.position, Vector2.up, 1);
		RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector2.up, 1);
		RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.up, 1);

		//Check Memory to see if ant already knows whats in the cell

		//Make a look check before moving in case something has changed

	}
}
