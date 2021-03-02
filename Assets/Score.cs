using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    //Scoreを表示するテキスト
    private GameObject scoreText;
    //Scoreの最初の値を代入
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        //scoreを表示
        this.scoreText.GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        //タグによって得点を変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 5;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 12;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 15;
        }

        this.scoreText.GetComponent<Text>().text = score.ToString();
    }
}
