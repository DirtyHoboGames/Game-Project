using UnityEngine;
using System.Collections;

public class GuardMovement : MonoBehaviour {

    public float speed;
    private Animator animator;
    private bool flipGuard = true;
    private Rigidbody2D guardBody;


    void Start() {
        animator = GetComponent<Animator>();
        guardBody = GetComponent<Rigidbody2D>();
        guardBody.velocity = new Vector2(speed,0);
        animator.SetBool("GHorizAnim", true);
    }

    void OnTriggerEnter2D(Collider2D colli) {
        if (colli.gameObject.tag=="Waypoint1") {
            guardBody.velocity = new Vector2(speed,0);
            GuardFlip(1);
        }
        if (colli.gameObject.tag == "Waypoint2") {
            guardBody.velocity = new Vector2(-speed, 0);
            GuardFlip(-1);
            
        }
    }

    void Update() {
        transform.rotation = Quaternion.identity;
    }
    private void GuardFlip(int direction) { //Flips the guards animation when going left. 
        if (direction > 0 && !flipGuard || direction < 0 && flipGuard) {
            flipGuard = !flipGuard;
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}






/* if (range2 <= maxDistance && range2 >= 0.9f) {
            transform.position = Vector2.MoveTowards(transform.position, target2.position, speed * Time.deltaTime);
            //animator.SetBool("GHorizAnim", true);
        }*/
