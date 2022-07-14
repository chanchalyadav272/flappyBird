using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{   
    private Bird bird;
    private PipeSpawner pipeSpawner;


    public Text scoreText;
    public Text highScoreText;
    public GameObject playButton;
    public GameObject gameOver;


    public void Awake(){
        Application.targetFrameRate =60;
        bird = FindObjectOfType<Bird>();
        pipeSpawner = FindObjectOfType<PipeSpawner>();

        Pause();
    }

    public void Play(){
        score= 0;
         scoreText.text = score.ToString();
         gameOver.SetActive(false);
        playButton.SetActive(false);
        Time.timeScale = 1f;
        bird.enabled = true;
         PipesMovement[] pipes = FindObjectsOfType<PipesMovement>();

        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
        


    }
    public void Pause(){
        Time.timeScale = 0f;
        bird.enabled = false;

    }
    private int score;
    private int highScore;

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        if(score>=highScore){
            highScore = score;
        }
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();

    }
}
