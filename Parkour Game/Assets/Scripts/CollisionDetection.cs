using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {


	void OnTriggerEnter (Collider other) {

        Debug.Log("Object is within trigger");
        transform.Translate(new Vector3(0, 0, 0));

	}
}
