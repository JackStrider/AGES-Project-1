using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour {

    public Color color = Color.black;

    // Use this for initialization
    void Start ()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(color.r, color.g, color.b, color.a);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
