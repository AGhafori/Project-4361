using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float moveSpeed = 25f;

    private Rigidbody rbody;
    private Renderer rend;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();

        rbody.velocity = new Vector3(0f, 15f, 10f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "wall1")
        {
            //print score for player 1
        }
        else if (col.collider.name == "wall2")
        {
            //print score for player 2
        }
    }
}
