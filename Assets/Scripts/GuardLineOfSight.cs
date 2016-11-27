using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets;
using Assets.Scripts;
using UnityEngine.SceneManagement;

public class GuardLineOfSight : MonoBehaviour {
    private Text dialog;
    int scene = SceneManager.GetActiveScene().buildIndex;
    void Start() {

        DialogScript.DialogInit();

        dialog = GameObject.Find("ShowDialog/DialogBox").GetComponent<Text>();

    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.CompareTag("Playa")) {
            //Time.timeScale = 0f;
            StatKeeper.receiveDamage(4);
            dialog.text = DialogScript.getDialog(14);
            Invoke("CheckStatus", 2);
        }
    }
    void CheckStatus() { 
        if (StatKeeper.getHealth() >=5) {
            SceneManager.LoadScene(scene,LoadSceneMode.Single);
            //Time.timeScale = 1f;
         }
    }
}