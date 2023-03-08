using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;

    public float forwardForce = 800f;
    public float sidewaysForce = 600f;

    // FixedUpdate naming while manipulating physics, is called once per frame
    void FixedUpdate() {
        // use deltatime to account for varying frame rate, more frame rate lesser it's value
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
