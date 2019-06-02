using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour {

	private MapScaler _mapScaler;

	[SerializeField]
	private bool _scaleHeight;
	[SerializeField]
	private bool _scaleWidth;
	[SerializeField]
	private GameObject _positionReference;
	[SerializeField]
	private bool _adjustPositionUp;
	[SerializeField]
	private bool _adjustPositionDown;
	[SerializeField]
	private bool _adjustPositionLeft;
	[SerializeField]
	private bool _adjustPositionRight;

	// Use this for initialization
	void Start () {
		_mapScaler = GetComponentInParent<MapScaler>();
		if (!_positionReference) _positionReference = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		// Check if scale changes, if it does update
		if(transform.localScale.x != _mapScaler.GetWidth() || transform.localScale.y != _mapScaler.GetHeight()) Scale();	
	}

	void Scale() {
		float w = _scaleWidth ? _mapScaler.GetWidth() : transform.localScale.x;
		float h = _scaleHeight ? _mapScaler.GetHeight() : transform.localScale.y;

		float px = _positionReference.transform.position.x;
		float py = _positionReference.transform.position.y;

		float nx = px;
		float ny = py;

		if (_adjustPositionUp) ny = py + (_mapScaler.GetHeight()/2) + (h/2);
		if (_adjustPositionDown) ny = py - (_mapScaler.GetHeight()/2) - (h/2);
		if(_adjustPositionLeft) nx = px - (_mapScaler.GetWidth()/2) - (w/2);
		if(_adjustPositionRight) nx = px + (_mapScaler.GetWidth()/2) + (w/2);

		transform.position = new Vector2(nx, ny);
		transform.localScale = new Vector2(w, h);
	}
}
