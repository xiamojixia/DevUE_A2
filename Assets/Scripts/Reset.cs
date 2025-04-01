using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    public void ResetPlayer()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}
