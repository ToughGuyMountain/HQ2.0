using UnityEngine;
using System.Collections;

public class MoveLight : MonoBehaviour {

	public Transform x;

	

	// Update is called once per frame
	void Update () {
		if (x.position.z < 5) {

						transform.Translate (Vector3.forward * Time.deltaTime * 3);

				} else if (x.position.z > 5) {
						
				transform.position = new Vector3(0,1,-6);		
		}
	
	}
}
