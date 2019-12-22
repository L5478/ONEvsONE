using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public GameObject gameplayUI;
    public GameObject gameoverUI;

    public Score score;

    public void GameOver()
    {
        gameplayUI.SetActive(false);
        gameoverUI.SetActive(true);

        gameoverUI.GetComponentInChildren<Text>().text = "SCORE: \n" + score.GetScore;
    }

    public void Retry()
    {

    }

}
