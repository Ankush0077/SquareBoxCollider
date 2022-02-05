using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 4000f;
    public float sidewaysForce = 10f;

    // Update is called once per frame
    // We marked this a "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y< -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
