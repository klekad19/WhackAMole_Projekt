using UnityEngine;

public class Mole : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float height = 0.5f;

    private Vector3 startPos;
    private GameManager gameManager;
    private float offset;

    private void Start()
    {
        startPos = transform.position;
        gameManager = FindObjectOfType<GameManager>();

        // random delay so they don't sync
        offset = Random.Range(0f, 100f);
    }

    private void Update()
    {
        if (gameManager.CurrentState != GameManager.GameState.Running)
            return;

        float y = Mathf.Sin((Time.time + offset) * moveSpeed) * height;
        transform.position = startPos + new Vector3(0, y, 0);
    }
}