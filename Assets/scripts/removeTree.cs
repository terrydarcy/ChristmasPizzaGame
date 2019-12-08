 using UnityEngine;

 public class removeTree : MonoBehaviour {

     public Rigidbody player;
     public SpriteRenderer spriteRenderer;

     void Update () {

         if (transform.position.x < player.transform.position.x) {
             spriteRenderer.sortingOrder = 1;
         } else {
             spriteRenderer.sortingOrder = 0;

         }
     }
 }