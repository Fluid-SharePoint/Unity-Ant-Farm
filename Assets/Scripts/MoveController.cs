using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

	private List<AntMove> _antsComponents;
	[SerializeField]
	private float _moveTimerDelay;
	[SerializeField]
	private bool _moveActive;
	[SerializeField]
	private float _spawnTimerDelay;
	[SerializeField]
	private bool _spawnActive;
	[SerializeField]
	private GameObject _antPrefab;
	[SerializeField]
	private GameObject _antContainer;
	private Vector2 _spawnPoint;
	private bool _moveRoutineActive;
	private bool _spawnRoutineActive;

	// Use this for initialization
	void Start () {
		_spawnPoint = new Vector2(0,0);
		_antsComponents = new List<AntMove>(FindObjectsOfType<AntMove>());
	}
	
	// Update is called once per frame
	void Update () {
		if (!_spawnRoutineActive && _spawnActive) {
			StartCoroutine(SpawnTimer());
		}
		if (!_moveRoutineActive && _moveActive) {
			StartCoroutine(MoveTimer());
		}
		
	}

	IEnumerator MoveTimer() {
		_moveRoutineActive = true;
		while(_moveActive){
			_MoveAnts();
			yield return new WaitForSeconds(_moveTimerDelay);
		}
		_moveRoutineActive = false;
	}

	IEnumerator SpawnTimer() {
		_spawnRoutineActive = true;
		while(_spawnActive){
			yield return new WaitForSeconds(_spawnTimerDelay);
			_SpawnAnt();
		}
		_spawnRoutineActive = false;
	}

	private void _MoveAnts() {
		foreach (AntMove a in _antsComponents) {
			a.TriggerMove();
		}
	}

	private void _SpawnAnt() {
		GameObject a = Object.Instantiate(_antPrefab, _spawnPoint, Quaternion.identity) as GameObject;
		if (_antContainer != null) a.transform.parent = _antContainer.transform;
		_antsComponents.Add(a.GetComponent<AntMove>());
	}
}
