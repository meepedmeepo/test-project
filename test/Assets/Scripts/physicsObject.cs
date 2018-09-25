using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsObject : MonoBehaviour {

    public float gravityModifier = 1f;
    protected const float minDistance = 0.001f;

    protected Vector2 velocity;

    protected Rigidbody2D rb2d;

   void OnEnable()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        velocity += gravityModifier * Physics2D.gravity * Time.deltaTime;
        Vector2 deltaPosition = velocity * Time.deltaTime;
        Vector2 move = Vector2.up * deltaPosition.y;
        Movement(move);
    }

    void Movement(Vector2 move)
    {
        float distance = move.magnitude;
        if (distance > minDistance)
        {

        }
        rb2d.position = rb2d.position + move;
    }

}


