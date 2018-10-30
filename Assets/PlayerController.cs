using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public int speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal");

        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.y += moveVertical * speed * Time.deltaTime;
        transform.position = position;
    }
}
