using UnityEngine;
using System.Collections;

public class killDuck : MonoBehaviour {

	public void OnTriggerEnter(Collider hit) {
		if(hit.tag == "killzone") {
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
