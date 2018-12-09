using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysMiles : MonoBehaviour {
    public int lives;
    public float xWidth;
    public float yWidth;
    public int[] pattern;
    public int playerPosition = 0;
    public int blinks;
    public int iteration = 2;
    public int playerInput = 4;
    bool correct = true;
    // Use this for initialization
    void Start()
    {
        blinks = 10;
        blink();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            xWidth = Screen.width / 2;
            yWidth = Screen.height / 2;
            if (Input.mousePosition.x > xWidth && Input.mousePosition.y > yWidth)
            {
                playerInput = 0;
                Debug.Log("0");
            }
            else if (Input.mousePosition.x < xWidth && Input.mousePosition.y > yWidth)
            {
                playerInput = 1;
                Debug.Log("1");
            }
            else if (Input.mousePosition.x > xWidth && Input.mousePosition.y < yWidth)
            {
                playerInput = 2;
                Debug.Log("2");
            }
            else if (Input.mousePosition.x < xWidth && Input.mousePosition.y < yWidth)
            {
                playerInput = 3;
                Debug.Log("3");
            }
            checkPlayerAns();
            if ((iteration < blinks) && correct)
            {
                Debug.Log("veep");
            }
        }
    }
    public void blink()
    {
      pattern = new int[blinks];
       for (int i = 0; i < blinks; i++)
       {
           pattern[i] = Random.Range(0, 4);
       }
    }
    public void checkPlayerAns()
    {
        if (pattern[playerPosition] == playerInput)
        {
            correct = true;
            //Debug.Log("boop");
        }
        else
        {
            correct = false;
        }
        if (iteration == playerPosition)
        {
            iteration++;
            playerPosition = 0;
        }
        else
        {
            playerPosition++;
        }
    }
}
