using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousForward : MonoBehaviour {

    public float Speed = 7f;

	void Start () {
		


	}
	
	void Update () {

        transform.Translate(0, 0, Speed* Time.deltaTime);

	}
}
