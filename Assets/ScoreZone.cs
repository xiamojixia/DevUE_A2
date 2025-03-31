using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public int scoreValue = 10;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        if (gameManager == null)
        {
            Debug.LogError("GameManager 未找到，请确保场景中存在 GameManager 脚本！");
        }
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
