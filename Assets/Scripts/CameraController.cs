using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // reference to the player GameOject
    public GameObject player;
    private Vector3 offset;

    // Get current transform position of the camera subtract the position of the player
    void Start () {
        offset = transform.position - player.transform.position;
	}

    // LateUpdate runs every frame just like Update() but it is guranteed to run after all items have been procssed by Update()
    void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
