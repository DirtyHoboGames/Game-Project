using UnityEngine;
using System.Collections;

public class GuardMovement : MonoBehaviour {

    Transform target;
    Transform target2;
    public float speed;
    private float minDistance = 2;
    private float maxDistance = 20;
    private float range;
    private float range2;
    private Animator animator;

    void Start() {
        animator = GetComponent<Animator>();
    }

    void Update() {
        target = GameObject.FindGameObjectWithTag("Waypoint2").transform;
        target2 = GameObject.FindGameObjectWithTag("Waypoint1").transform;
        range = Vector2.Distance(transform.position, target.position);
        range2 = Vector2.Distance(transform.position, target2.position);


        if (range <= maxDistance) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            animator.SetBool("GHorizAnim", true);

        }
        /*if (range >1) {
            transform.position = Vector2.MoveTowards(transform.position, target2.position, speed * Time.deltaTime);
        } */
    }
}
