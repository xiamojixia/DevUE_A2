using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 小球进入得分区
        if (other.CompareTag("ScoreZone"))
        {
            FindObjectOfType<GameManager>().AddScore(10);  // 加分
            Destroy(gameObject);  // 小球销毁
        }

        // 小球掉出游戏区域
        if (other.CompareTag("OutOfBounds"))
        {
            Destroy(gameObject);
        }
    }
}