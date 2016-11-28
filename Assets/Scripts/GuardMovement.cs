using UnityEngine;
using System.Collections;

public class GuardMovement : MonoBehaviour {

    Transform target;
    Transform target2;
    public float speed;
    private float minDistance = 0.1f;
    private float maxDistance = 20;
    private float range;
    private float range2;
    private Animator animator;
    private bool flipGuard = true;

    void Start() {
        animator = GetComponent<Animator>();
    }

    void Update() {
        target = GameObject.FindGameObjectWithTag("Waypoint2").transform;
        target2 = GameObject.FindGameObjectWithTag("Waypoint1").transform;
        range = Vector2.Distance(transform.position, target.position);
        range2 = Vector2.Distance(transform.position, target2.position);


        if (range <= maxDistance) { //moves the guard to waypoint (target = waypoint2)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            animator.SetBool("GHorizAnim", true);
            }
        if (range <= minDistance) {
            animator.SetBool("GHorizAnim", false);
        }
       /* if (range2 <= maxDistance && range2 >= 0.5f) { // doesnt work pls fix
            transform.position = Vector2.MoveTowards(transform.position, target2.position, speed * Time.deltaTime);
        }*/
        
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
