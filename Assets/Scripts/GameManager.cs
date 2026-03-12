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
        CurrentState = GameState.Running;
        Debug.Log("Game Started");
    }
}