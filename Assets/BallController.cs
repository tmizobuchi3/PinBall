using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController: MonoBehaviour
{
    //ボールが見える可能性のあるZ軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    private GameObject ScoreText;

    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

        this.ScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 30;
            ScoreText.GetComponent<Text>().text = score.ToString();
        }

        if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 15;
            ScoreText.GetComponent<Text>().text = score.ToString();
        }


            if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
            ScoreText.GetComponent<Text>().text = score.ToString();
        }

        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 5;
            ScoreText.GetComponent<Text>().text = score.ToString();
        }
    }


}
