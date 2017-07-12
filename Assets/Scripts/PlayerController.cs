using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    // public variable will be shown in the Inspector as an editable property
    public float speed;
    // Reference to countText UI
    public Text countText;
    // Reference to winTwxt UI
    public Text winText;
    // Attach this script to Rigidbody of the same game object
    private Rigidbody rb;
    // Count the total number of the PickUp object we've collected
    private int count;

    // Attach to Rigidbody on the first frame when this script was initialized
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame (Before rendering a frame, most of our game codes go here)
    // Called before any physics calculations(physics codes go here)
    void FixedUpdate () {
        // Grab player input through keyboard 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Add force to Rigidbody, move player object in scene
        rb.AddForce(movement *　speed);
	}

    // Collide with the PickUp object
    void OnTriggerEnter(Collider other) {
        // if the collider object is a PickUp object then deactivate the PickUp object
        if(other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            // Count this collision as we collide (collect) the PickUp object
            count += 1;
            SetCountText();
        }
    }

    void SetCountText() {
        countText.text = "Count: " + count.ToString();
        if (count >= 12) {
            winText.text = "You Win!";
        }
    }
}
