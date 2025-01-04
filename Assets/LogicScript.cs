using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public Text ScoreText;
    public GameObject GameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int ScoreToAdd)
    {
        playerscore = playerscore + ScoreToAdd;
        ScoreText.text = playerscore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

}
