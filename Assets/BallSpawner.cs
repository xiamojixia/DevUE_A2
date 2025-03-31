using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;       // 小球预制体
    public float spawnInterval = 5f;    // 发射间隔
    public float ballSpeed = 4f;       // 初速度

    private void Start()
    {
        InvokeRepeating("SpawnBall", 1f, spawnInterval);
    }

    private void SpawnBall()
    {
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        
        // 给小球施加初速度
        Vector3 forceDirection = transform.forward + Vector3.up * 0.2f;
        rb.AddForce(forceDirection * ballSpeed, ForceMode.Impulse);
    }
}
