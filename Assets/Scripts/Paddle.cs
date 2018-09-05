using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidth = 16f;
    [SerializeField] float minX = 0.83f;
    [SerializeField] float maxX = 15.17f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var mousePosX = Input.mousePosition.x / Screen.width * screenWidth;
        Vector2 paddlePos = new Vector2(mousePosX, transform.position.y);
        paddlePos.x = Mathf.Clamp(paddlePos.x, minX, maxX);
        transform.position = paddlePos;
	}
}
