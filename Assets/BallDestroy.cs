using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public string targetTag = "Pit";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(gameObject);
        }
    }
}
