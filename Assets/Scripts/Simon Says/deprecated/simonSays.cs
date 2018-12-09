using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSays : MonoBehaviour {
    public int[,] pattern; 
    public int[,] playerPattern;
    private int xWidth;
    private int yWidth;
    public int position = 0;
    public int playerPosition;
    public int amountPosition = 0;
	public int[] randGen;

    // Use this for initialization
    void Start() {
        xWidth = Screen.width / 2;
        yWidth = Screen.height / 2;
		playerPosition = 0;
    }
   // Update is called once per frame
    void Update() {
        blink();
        playerClick();
    }
    public void playerClick() {
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x < xWidth && Input.mousePosition.y > yWidth) { /* checks if mouse clicks top left of screen */
            playerPattern = new int[playerPosition, 0];
            playerPosition++;
            //Debug.Log("Top left");
        }
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x > xWidth && Input.mousePosition.y > yWidth) { /* checks if mouse clicks top right of screen */
            playerPattern = new int[playerPosition, 1];
            playerPosition++;
            //Debug.Log("Top right");
        }
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x > xWidth && Input.mousePosition.y < yWidth) { /* checks if mouse clicks bottom right of screen */
            playerPattern = new int[playerPosition, 2];
            playerPosition++;
            //Debug.Log("Bottom right");
        }
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x < xWidth && Input.mousePosition.y < yWidth) { /* checks if mouse clicks bottom left of screen */
            playerPattern = new int[playerPosition, 3];
            playerPosition++;
            //Debug.Log("Bottom left");
        }
    }
    public void blink() {
        for (int i = 0; i < amountPosition; i++) {
			randGen = new int [Random.Range(0, 3)];
            pattern = new int[position, randGen[amountPosition]];
            position++;
        }
    }
}