using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private GameObject scoreText;
    int GameScore = 0;

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "SmallStarTag")
        {
            GameScore += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            GameScore += 20;
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

        // Use this for initialization
        void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "Score:" + GameScore;

        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
           
        }
    }
}
