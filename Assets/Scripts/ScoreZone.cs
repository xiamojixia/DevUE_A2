using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public int scoreValue = 10;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (gameManager != null)
            {
                gameManager.AddScore(scoreValue);
            }

            Destroy(collision.gameObject);
        }
    }
}
