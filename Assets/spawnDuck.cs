using UnityEngine;
using System.Collections;

public class spawnDuck : MonoBehaviour {

	public GameObject duck;

	public void spawn() {

		Instantiate (duck, transform.position, Quaternion.identity);

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
