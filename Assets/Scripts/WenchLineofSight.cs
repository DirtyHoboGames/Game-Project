using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets;
using Assets.Scripts;

public class WenchLineofSight : MonoBehaviour {
    private Text dialog;

    void Start() {

        DialogScript.DialogInit();

        dialog = GameObject.Find("ShowDialog/DialogBox").GetComponent<Text>();

    }

    void OnTriggerEnterWench2D(Collider2D coll) {
        if (coll.CompareTag("Playa")) { //if player hits the collider, time freezes and dialogue follows.
            Time.timeScale = 0f;

            dialog.text = DialogScript.getDialog(int.Parse(coll.gameObject.name));
            //dialog "hah, found ya"
            //"give rose or fucking get slapped to death"

        }
    }
}
