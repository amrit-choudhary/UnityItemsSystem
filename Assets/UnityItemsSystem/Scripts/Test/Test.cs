using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    TestParam health1 = new TestParam(6, "Health 1");
    TestParam health2 = new TestParam(3, "Health 2");

    // Use this for initialization
    void Start () {
        Debug.Log(health1.ID);
        Debug.Log(health2.ID);

        if (health1 != health2) {
            Debug.Log("health not equal");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
