using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Transform playerpaddle;
    public Transform enemypaddle;

    public BallControler ballControler;

    public int playerscore = 0;
    public int enemyscor = 0;

    public TextMeshProUGUI textPointPlayer;
    public TextMeshProUGUI textPointEnemy;

 
    public float Derleintes = 1f;

    public int WinPoint = 2;

    public GameObject screenEndGame;

    public TextMeshProUGUI textEndGame;
      
    public void CheckWinPoint()
    {
        if(playerscore >= WinPoint)
        {

            //ResetGame();
            EndGame();
        }
        if(enemyscor >= WinPoint)
        {

            //ResetGame();
            EndGame();
        }
    }

    public void EndGame()
    {
        screenEndGame.SetActive(true);
        string winner = SaveControler.Instance.GetName(playerscore > enemyscor);
        textEndGame.text = "Vitória " + winner;
        SaveControler.Instance.SaveWinner(winner);
        Invoke("LoadMenu", 2f);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        playerpaddle.position = new Vector3(-7f, 0f, 0f);
        enemypaddle.position = new Vector3(7f, 0f, 0f);

        ballControler.ReserBall();

        playerscore = 0;
        enemyscor = 0;

        textPointEnemy.text = enemyscor.ToString();
        textPointPlayer.text = enemyscor.ToString();

        screenEndGame.SetActive(false);
    }

    public void ScorePlayer()
    {
        playerscore++;
        textPointPlayer.text = playerscore.ToString();
        CheckWinPoint();
    }

    public void ScoreEnemy()
    {
        enemyscor++;
        textPointEnemy.text = enemyscor.ToString();
        CheckWinPoint();
    }

    internal void enemyscore()
    {
        throw new NotImplementedException();
    }
}
