using UnityEngine;

public class GalaxyRotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
