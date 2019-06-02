using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveType {
	UP,
	DOWN,
	LEFT,
	RIGHT
}

public class AntMove : MonoBehaviour {

	private List<string> _moveArray = new List<string>();
	private string _backMove;

	public void TriggerMove(List<MoveType> moveOptions) {
		if(moveOptions.Count > 0) _RandMove();
	}

	private void _RandMove() {
		string move = _moveArray[Random.Range(0, _moveArray.Count)];
		switch (move) {
			case "up":
			_MoveUp();
			break;
			case "down":
			_MoveDown();
			break;
			case "right":
			_MoveRight();
			break;
			case "left":
			_MoveLeft();
			break;
		}
		_moveArray.Clear();
	}

	private void _MoveUp() {
		transform.position = (Vector2)transform.position + Vector2.up;
		_backMove = "down";
	}

	private void _MoveDown() {
		transform.position = (Vector2)transform.position + Vector2.down;
		_backMove = "up";
	}

	private void _MoveRight() {
		transform.position = (Vector2)transform.position + Vector2.right;
		_backMove = "left";
	}

	private void _MoveLeft() {
		transform.position = (Vector2)transform.position + Vector2.left;
		_backMove = "right";
	}
}
