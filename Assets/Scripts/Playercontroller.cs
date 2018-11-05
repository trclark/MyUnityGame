using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {

    private Rigidbody rb;

    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }

    }

    // Fixedupdate is called before any physics calculations
    void FixedUpdate() {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
