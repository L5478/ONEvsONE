using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    public bool invert;

    private void Start()
    {
        float randomRotate = Random.Range(0f, 360f);

        transform.Rotate(Vector3.forward * randomRotate);
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
}
