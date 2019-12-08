using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform santa;
    public Vector3 offset;
    public Vector3 rot;
    void start () {
        transform.Rotate (rot.x, rot.y, rot.z, Space.Self);

    }
    void Update () {
        transform.position = new Vector3(santa.position.x, 0f, santa.position.z) + offset;
    }
}