using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Idle,
        Running,
        Ended
    }

    public GameState CurrentState = GameState.Idle;

    private void Start()
    {
        Debug.Log("GameManager is active");
    }

    public void StartGame()
    {
        if (CurrentState == GameState.Running)
            return;

        CurrentState = GameState.Running;
        Debug.Log("Game Started");
    }

    public void StopGame()
    {
        if (CurrentState == GameState.Ended)
            return;

        CurrentState = GameState.Ended;
        Debug.Log("Game Ended");
    }
}