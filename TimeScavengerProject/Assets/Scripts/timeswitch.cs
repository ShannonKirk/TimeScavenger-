using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeswitch : MonoBehaviour {

    public GameObject past;
    public GameObject future;

    // Use this for initialization
    void Start () {

        past.SetActive(false);
        future.SetActive(true);
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (past.activeInHierarchy == true && future.activeInHierarchy == false)
            {
                past.SetActive(false);
                future.SetActive(true);
                
            }
            else if (past.activeInHierarchy == false && future.activeInHierarchy == true)
            {
                past.SetActive(true);
                future.SetActive(false);
                
            }
        }  
    }
}


