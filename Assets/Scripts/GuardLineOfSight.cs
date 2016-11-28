using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets;
using Assets.Scripts;
using UnityEngine.SceneManagement;

public class GuardLineOfSight : MonoBehaviour { //Script for guards to detect player, hit the player and teleport the player to the beginning 
    private Text dialog;                        //of the level.
    int scene = SceneManager.GetActiveScene().buildIndex;
    private bool spotted;
    void Start() {
        
        DialogScript.DialogInit();

        dialog = GameObject.Find("ShowDialog/DialogBox").GetComponent<Text>();

    }

    void OnTriggerEnter2D(Collider2D coll) { //guard collider checks for player and deals damage, says some stuff, invokes checkstatus method.
        if (coll.CompareTag("Playa")) {
            
            StatKeeper.receiveDamage(4);
            dialog.text = DialogScript.getDialog(14);
            spotted = true;
            //Invoke("CheckStatus", 1);
        }
    }
    void Update() {
        if (spotted == true) {
            CheckStatus();
        }
    }

    void CheckStatus() { 
        if (StatKeeper.getHealth() >=5) {
            SceneManager.LoadScene(5);
            
        }
    }
}