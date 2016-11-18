using UnityEngine;
using System.Collections;

public class CheckForInteraction : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D colli) {

        if(colli.CompareTag("NPC") == true) {

            

            Debug.Log("NPC spotted");



        }

    }
}
