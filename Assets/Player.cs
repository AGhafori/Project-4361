using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float paddleSpeed = 10f;
    
    private Rigidbody pbody;

    // Use this for initialization
    void Start ()
    {
        pbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        float moveX = inputX * paddleSpeed * Time.deltaTime;
        float moveY = inputY * paddleSpeed * Time.deltaTime;

        pbody.AddForce(moveX, moveY, 0f);

    }
}
