using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Idle,
        Running,
        Ended
    }

    public GameState CurrentState = GameState.Idle;

    public int score = 0;
    public float roundDuration = 30f;

    private float timer;

    [Header("UI")]
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public GameObject gameOverText;

    private void Start()
    {
        timer = roundDuration;
        UpdateUI();

        if (gameOverText != null)
            gameOverText.SetActive(false);
    }

    private void Update()
    {
        if (CurrentState != GameState.Running)
            return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = 0f;
            StopGame();
        }

        UpdateUI();
    }

    public void StartGame()
    {
        if (CurrentState == GameState.Running)
            return;

        score = 0;
        timer = roundDuration;
        CurrentState = GameState.Running;

        if (gameOverText != null)
            gameOverText.SetActive(false);

        UpdateUI();
        Debug.Log("Game Started");
    }

    public void StopGame()
    {
        if (CurrentState == GameState.Ended)
            return;

        CurrentState = GameState.Ended;

        if (gameOverText != null)
            gameOverText.SetActive(true);

        UpdateUI();
        Debug.Log("Game Ended");
        Debug.Log("Final Score: " + score);
    }

    public void AddScore(int amount)
    {
        if (CurrentState != GameState.Running)
            return;

        score += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;

        if (timerText != null)
            timerText.text = "Time: " + Mathf.CeilToInt(timer);
    }
}