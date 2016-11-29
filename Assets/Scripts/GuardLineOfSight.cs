using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets;
using Assets.Scripts;
using UnityEngine.SceneManagement;

public class GuardLineOfSight : MonoBehaviour { //Script for guards to detect player, hit the player and teleport the player to the beginning 
    
	private Text dialog;                        //of the level.
	private bool spotted;
	private Vector3 entrance = new Vector3(-16.10f, -5.782f, -0.355f);
	private GameObject player;

    void Start() {

		player = GameObject.Find ("Player");

        DialogScript.DialogInit();

        dialog = GameObject.Find("ShowDialog/DialogBox").GetComponent<Text>();

    }

    void OnTriggerEnter2D(Collider2D coll) { //guard collider checks for player and deals damage, says some stuff, invokes checkstatus method.
        if (coll.CompareTag("Playa")) {
            
            StatKeeper.receiveDamage(4);
            dialog.text = DialogScript.getDialog(14);
            spotted = true;

        }
    }
    void Update() {
        if (spotted == true) {
			
            CheckStatus();

			player.transform.position = entrance;

			spotted = false;


        }
    }

    void CheckStatus() { 
        if (StatKeeper.getHealth() >=5) {
            
			StatKeeper.receiveDamage (4);
			player.transform.TransformPoint (entrance);
            
        }
    }
}