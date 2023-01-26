using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public bool liveCheck = false;
    static public bool scoreCheck = false;
    [SerializeField] int playerLive = 3;
    private int score = 0;
    private bool overCheck = false;
    private int overCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives: "+ playerLive);
        Debug.Log("Score: " + score);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        minusLive();
        addScore();
        GameOver();
    }

    private void minusLive()
    {
        if (liveCheck == true && playerLive >0)
        {
            playerLive--;
            Debug.Log("Lives: " + playerLive);
            liveCheck = false;
        }
        if (playerLive == 0)
        {
            overCount++;
            overCheck = true;
        }
    }
    private void addScore()
    {
        if (scoreCheck == true)
        {
            score++;
            Debug.Log("Score: " + score);
            scoreCheck = false;
        }
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    private void GameOver()
    {
        if (overCheck == true && overCount == 1)
        {
            Debug.Log("Game Over!");
            UnityEditor.EditorApplication.ExitPlaymode();
        }
    }
}
