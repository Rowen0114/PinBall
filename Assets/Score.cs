using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private GameObject scoreText;
    int GameScore = 0;





    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score:" + GameScore;

    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "Score:" + GameScore;

    }

    void OnCollosionEnter(Collision other)
    {
        

        if (other.gameObject.tag == "SmallStarTag")
        {
            GameScore += 10;
            Debug.Log("1111");

        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            GameScore += 20;
            Debug.Log("1111");
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            GameScore += 30;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            GameScore += 50;
        }




    }





}
