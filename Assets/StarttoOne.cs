using UnityEngine;
using System.Collections;

public class StarttoOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Period))
        {
            Application.LoadLevel("1");
        }
	}
}
