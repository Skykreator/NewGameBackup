using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour
{
    public int type;
    public int lives;
	public float xWidth;
	public float yWidth;

    // Use this for initialization
    void Start() {
        
    }
    // Update is called once per frame
    void Update() {
		xWidth = Screen.width / 2;
		yWidth = Screen.height / 2;
		
    }
	private void OnMouseDown() {
		if (transform.position.x > xWidth && transform.position.y > yWidth) {
			type = 0;
		} else if (transform.position.x < xWidth && transform.position.y > yWidth) {
			type = 1;
		} else if (transform.position.x > xWidth && transform.position.y < yWidth) {
			type = 2;
		} else if (transform.position.x < xWidth && transform.position.y < yWidth) {
			type = 3;
		}
	}
}
