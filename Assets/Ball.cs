using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ScoreZone"))
        {
            FindObjectOfType<GameManager>().AddScore(1);
            Destroy(gameObject);
        }

        if (other.CompareTag("OutOfBounds"))
        {
            Destroy(gameObject);
        }
    }
}