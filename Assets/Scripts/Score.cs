using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Vector3 currentPos;
    private Vector3 lastPos;

    public Text scoreText;

    private int score;

    public int GetScore { get => score; }

    private void Start()
    {
        score = 0;
        lastPos = transform.position;
    }

    private void Update()
    {
        if (transform.position.y >= lastPos.y)
        {
            score++;
            scoreText.text = "SCORE: " + score;
        }
        if (lastPos.y < transform.position.y)
        {
            lastPos = transform.position;
        }
    }
}
