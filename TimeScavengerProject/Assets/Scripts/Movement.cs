using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    private SpriteRenderer mySpriteRenderer;

    // Use this for initialization
    void Start () {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frame
    void Update()


    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-speed, 0, 0);
            mySpriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(speed, 0, 0);
            mySpriteRenderer.flipX = false;
        }


    }
}
