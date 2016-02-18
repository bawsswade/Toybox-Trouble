using UnityEngine;
using System.Collections;

public class setChar : MonoBehaviour {

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Period))
        {
            Application.LoadLevel("start");
        }
    }
	void OnMouseDown()
    {
        Application.LoadLevel("start");
    }

    public void OnClick()
    {
        Application.LoadLevel("start");
    }
}
