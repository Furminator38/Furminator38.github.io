using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovementCube : MonoBehaviour {

    public float xSpeed;

    void Start () {

        xSpeed = 7f;

	}
	
	void Update () {

        transform.Translate(xSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);

	}
}
