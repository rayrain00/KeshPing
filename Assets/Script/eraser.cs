using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eraser : MonoBehaviour {
    public float ForceScale;
    public float PointScale;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            RandomForce();
        }		
	}

    void RandomForce()
    {
        Vector2 Force = new Vector2(Random.Range(-1 * ForceScale, ForceScale), Random.Range(-1 * ForceScale, ForceScale));
        Vector2 Point = gameObject.GetComponent<Rigidbody2D>().position + new Vector2(Random.Range(-1 * PointScale, PointScale), Random.Range(-1 * PointScale, PointScale));

        gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(Force, Point);
    }
}
