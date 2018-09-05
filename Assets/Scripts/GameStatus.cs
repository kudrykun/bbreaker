using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroy = 83;
    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] int score = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        SetScoreText(0);
    }

    void Update () {
        Time.timeScale = gameSpeed;
	}

    public void addToScore()
    {
        score += pointsPerBlockDestroy;
        SetScoreText(score);
    }

    private void SetScoreText(int score)
    {
        scoreText.SetText(score.ToString());
    }
}
