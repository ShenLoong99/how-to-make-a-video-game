using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float sidewayForce = 50f;
    public float forwardForce = 1000f;
    public float jumpStrength = 500f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //}

        //if (Input.GetKey("s"))
        //{
        //    rb.AddForce(0, 0, -speed * Time.deltaTime);
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
