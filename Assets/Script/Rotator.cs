using UnityEngine;

public class Rotator : MonoBehaviour
{
public float rotationSpeed = 60f; // Speed of rotation in degrees per second
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
