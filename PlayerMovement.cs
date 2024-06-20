using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardf = 2000f;
    public float sidewaysf = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardf * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey (KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysf * Time.deltaTime, 0, 0,ForceMode.VelocityChange );
        }
        if (Input.GetKey("a") || Input.GetKey (KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysf * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s") || Input.GetKey (KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -forwardf * Time.deltaTime);
        }
        if (Input.GetKey("w") || Input.GetKey (KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, forwardf + 500);
        }
        if (Input.GetKey (KeyCode.Space))
        {
            rb.AddForce(0, 50, 0, ForceMode.Force);
        }
        if (rb.position.y < -1f || rb.position.y > 5f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
