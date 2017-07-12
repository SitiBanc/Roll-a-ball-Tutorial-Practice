using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	
	// Spin the PickUp object every frame
	void Update () {
        // multiply by deltaTime to be smooth and frame rate independent
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
