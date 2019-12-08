using UnityEngine;

public class movement : MonoBehaviour {

    public Rigidbody rb;
    Vector3 startPos = new Vector3 (0.1f, 0.1f, 0f);
    public float speed = 1f;

    void FixedUpdate () {
        if (rb.position.x > 20.0f) {
            Debug.Log (rb.position.x);
            gameObject.transform.position = new Vector3 (0.1f, 0.1f, 0f);
        }
        gameObject.transform.position += new Vector3 (speed * Time.deltaTime, 0f, 0f);

        if (Input.GetKey ("a")) {
            gameObject.transform.position += new Vector3 (0f, 0f, speed * Time.deltaTime);
        } else if (Input.GetKey ("d")) {
            gameObject.transform.position -= new Vector3 (0f, 0f, speed * Time.deltaTime);
        }

        if (Input.GetKeyDown ("space")) {
            if (rb.velocity.y <= 0)
                rb.AddForce (Vector3.up * 100f);
        }
    }
}