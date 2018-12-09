using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBoard : MonoBehaviour {
    private int score;
    private List<int> scoreList;
    
	// Use this for initialization
	void Start () {
        scoreList = new List<int>(); // Defines score as an object list
    }
	
	// Update is called once per frame
	void Update () {
        for (int amount = 0; amount < 50; amount++) {
            score = Random.Range(1, 100); // Selects a random integer between 1 and 100
            scoreList.Add(score); // Adds the score to the list forever
            // Debug.Log(scoreArray);
        }
        
        
    }
}
