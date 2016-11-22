using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets;

namespace Assets.Scripts {
    public class CheckForInteraction : MonoBehaviour {

        public Text dialog;


        void Start() {
            dialog = GameObject.Find("ShowDialog/DialogBox").GetComponent<Text>();
        }

        

        void OnTriggerEnter2D(Collider2D colli) {

            if (colli.CompareTag("NPC") == true) {

                dialog.text = DialogScript.CheckDialog(1);

            }

            else if (colli.CompareTag("HiddenHoboCoin") == true) {

                Debug.Log("Oh look, a HoboCoin !");

                StatKeeper.collectHoboCoin();

            } else if(colli.CompareTag("HostileNPC") == true) {

                StatKeeper.receiveDamage(2);

            }



        }
    }
}