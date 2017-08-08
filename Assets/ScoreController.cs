using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    private int points = 0;

    private int degree = 0;

    private GameObject scoreText;


	// Use this for initialization
	void Start () {

        this.scoreText = GameObject.Find("ScoreText");

        

	}

    // Update is called once per frame
    void Update()
    {
        
    }
        private void OnCollisionEnter(Collision other)
        {
            degree = 180;

            if (other.gameObject.tag == "SmallStarTag")
            {
                this.points += 5;
            }
            else if (other.gameObject.tag == "LargeStarTag")
            {
                this.points += 15;
            }
            else if (other.gameObject.tag == "SmallCloudTag")
            {
                this.points += 10;
            }
            else if (other.gameObject.tag == "LargeCloudTag")
            {
                this.points += 20;
            }
        this.scoreText.GetComponent<Text>().text = "Score"+this.points;

    }

    
}
