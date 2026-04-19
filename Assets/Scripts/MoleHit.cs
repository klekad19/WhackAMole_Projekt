using UnityEngine;

public class MoleHit : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Hit()
    {
        if (gameManager.CurrentState != GameManager.GameState.Running)
            return;

        Debug.Log("Hit!");
        gameManager.AddScore(1);
    }
}