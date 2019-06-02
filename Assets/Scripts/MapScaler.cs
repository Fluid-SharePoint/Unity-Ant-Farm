using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScaler : MonoBehaviour {

	[SerializeField]
	private float _width;
	[SerializeField]
	private float _height;

	// Use this for initialization
	void Start () {
		// Set default values for width and height
		if (_height < 0) _height = 10;
		if (_width < 0) _width = 10; 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public float GetWidth() {
		return _width;
	}

	public float GetHeight() {
		return _height;
	}
}
