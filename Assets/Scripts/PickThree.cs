using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickThree : MonoBehaviour
{

    public bool go; // Tells when card scripts to start
    public int loopLength; // How many cards it takes
    public bool correct; // If the player is correct
    public bool game; // If you are playing the game
    public int playerInput; // What the player selects
    public int[] pattern;
    public int playerPosition = 0;
    public int cards;
    bool wait;

    // Use this for initialization
    void Start()
    {
        go = false;
        playerInput = 3;
        correct = true;
        game = true;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Choose()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < loopLength; i++)
            {
                go = true;
                checkPlayerAns();
            }
            game = false; // Tells if game is happening for future use
        }
    }
    public void checkPlayerAns()
    {
        if (pattern[playerPosition] == playerInput)
        {
            correct = true;
            Debug.Log("boop");
        }
        else
        {
            correct = false;
        }
        playerPosition++;
        playerInput = 3; // Jank
    }
    public void card()
    {
        // Sets up how long the pattern is
        pattern = new int[cards];
        for (int i = 0; i < cards; i++)
        {
            // Adds random numbers 0-2 even though it says "(0, 3)" idk why, but it works
            pattern[i] = Random.Range(0, 3);
        }
    }
}