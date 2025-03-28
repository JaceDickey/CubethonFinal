using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public static bool makeLightweight = false;
    public static bool makeHeavy = false;
    public static bool makeJump = false;
    public static bool moving;

    public float forwardForce = 5000f;
    public float sidewaysForce = 150f;

    void Update()
    {
        if (makeLightweight == true)
        {
            rb.mass = 0.5f;
            makeLightweight = false;
            forwardForce = 0f;
            sidewaysForce = 0f;
            makeHeavy = false;
            moving = false;
            rb.drag = 0f;
            makeLightweight = false;
        }
        if (makeHeavy == true)
        {
            rb.mass = 1.0f;
            rb.drag = 1.0f;
            makeHeavy = false;
        }
        if (makeJump == true)
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            makeJump = false;
        }
    }
    void Start()
    {
        forwardForce = 5000f;
        sidewaysForce = 150f;
        makeHeavy = true;
        makeJump = false;
        moving = true;
    }

    void FixedUpdate()
    {
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (moving == true)
        {
            move();
        }
    }
    public void move()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
