using UnityEngine;

public class TreeGen : MonoBehaviour {

    public Transform ground;
    public GameObject tree;
    //public SpriteRenderer groundSprite;
    public int treeQ;

    void Start () {
        Vector3[] trees = new Vector3[treeQ];

        float groundWidth = gameObject.GetComponent<Renderer> ().material.mainTexture.width / 100f;
        float groundLength = gameObject.GetComponent<Renderer> ().material.mainTexture.height / 100f;

        float treeWidth = tree.GetComponent<SpriteRenderer> ().bounds.size.x;

        for (int i = 0; i < treeQ; i++) {
            float minZ = groundWidth / 2 +treeWidth/2;
            float maxZ = (ground.position.z - groundWidth / 2) + treeWidth+0.1f;
            float randTreeZ = Random.Range (minZ, maxZ);

            float minX = 0;//ground.position.x + 0.1f;
            float maxX = ( groundLength) ;
            float randTreeX = Random.Range (minX, maxX);

            Instantiate (tree, new Vector3 (randTreeX, 0.0f, randTreeZ), Quaternion.Euler (new Vector3 (0.0f, 90.0f, 0.0f)));
        }
        Vector3 pos = new Vector3 (0.0f, 0.0f, 0.0f);

    }

    void Update () {

    }
}