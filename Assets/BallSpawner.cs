using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 5f;
    public float ballSpeed = 4f;
    private void Start()
    {
        InvokeRepeating("SpawnBall", 1f, spawnInterval);
    }

    private void SpawnBall()
    {
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();

        Vector3 forceDirection = transform.forward + Vector3.up * 0.2f;
        rb.AddForce(forceDirection * ballSpeed, ForceMode.Impulse);
    }
}
