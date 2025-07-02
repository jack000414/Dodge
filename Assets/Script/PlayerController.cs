using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        //Debug.Log("xInput: " + xInput);
        float zInput = Input.GetAxis("Vertical");
        //Debug.Log("zInput: " + zInput);

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.linearVelocity = newVelocity;

    }

    public void Die()
    {
        gameObject.SetActive(false);
        GameManager gamemanager = FindFirstObjectByType<GameManager>();
        
        gamemanager.EndGame();
    }
}
