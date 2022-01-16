using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public Text ScoreText;
    //public Text HighScoreText;
    public GameObject targets;

    int score = 0;
   // int highscore = 0;

    // Start is called before the first frame update
    void Start()
    {

        ScoreText.text = score.ToString() + "score";
        //HighScoreText.text = "highscore = " + highscore.ToString();
    } 

    // public void AddPoint(){
    //     score += 1;
    // }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter2D(Collider2D targets){
        if(targets.tag == "Enemy"){
            score--;
            ScoreText.text = " score = "+score;
            Destroy(targets.gameObject);
        }
        else if (targets.tag == "Heart"){
            score ++;
            ScoreText.text = " score = "+score;
            Destroy(targets.gameObject);
        }
        else if(targets.tag == "Level2"){
            SceneManager.LoadScene("Level 2");
        }
        else if(targets.tag == "Level3"){
            SceneManager.LoadScene("Level 3");
        }
    }

}
