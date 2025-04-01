using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject cylPrefab;

    private GameObject currentShape;
    public Slider sizeSlider;

    private float rotationSpeed = 1800f;
    public float moveDistance = 1f;

    private float initialSize = 50f;

    void Start()
    {
        SwitchShape(cubePrefab);
        sizeSlider.value = 0.2f;
    }

    void Update()
    {
        float size = sizeSlider.value;
        currentShape.transform.localScale = new Vector3(size, size, size);
    }

    public void SwitchShape(GameObject newShapePrefab)
    {
        if (currentShape != null)
        {
            Destroy(currentShape);
        }

        currentShape = Instantiate(newShapePrefab, transform.position, Quaternion.identity);
        currentShape.transform.SetParent(transform);

        float size = initialSize / 100f;
        currentShape.transform.localScale = new Vector3(size, size, size);
    }

    public void RotateY() => currentShape.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

    public void MoveUp() => transform.position += Vector3.forward * moveDistance;
    public void MoveDown() => transform.position += Vector3.back * moveDistance;
    public void MoveLeft() => transform.position += Vector3.left * moveDistance;
    public void MoveRight() => transform.position += Vector3.right * moveDistance;

    void LateUpdate()
{
    Camera.main.transform.position = new Vector3(currentShape.transform.position.x, Camera.main.transform.position.y, currentShape.transform.position.z - 10);
}
}
