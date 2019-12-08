using UnityEngine;

public class setGroundSize : MonoBehaviour {

    void Start () {

        float xScale = gameObject.GetComponent<Renderer> ().material.mainTexture.width / 1000f;
        float zScale = gameObject.GetComponent<Renderer> ().material.mainTexture.height / 1000f;

        gameObject.transform.localScale = new Vector3 (xScale, 1f, zScale);

        gameObject.transform.position = new Vector3 ((zScale / 2) * 10f, 0f, 0f);
    }

    void Update () {

    }
}