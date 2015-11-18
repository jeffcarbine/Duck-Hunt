using UnityEngine;
using System.Collections;

public class directionChanger : MonoBehaviour {

	public enum Changer {Horizontal, Vertical};
	public Changer changer;

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}

	void OnCollisionEnter(Collision hit) {
		if (hit.transform.tag == "Duck") {
			moveDuck movement = hit.gameObject.GetComponent<moveDuck>();
			if(changer == Changer.Horizontal) {
				movement.DirectionChanger (new Vector3(-1,1,0));
			} else if (changer == Changer.Vertical) {
				movement.DirectionChanger (new Vector3(1,-1,0));
			}
		}
	}
}
