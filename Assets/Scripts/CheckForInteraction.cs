using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets;

namespace Assets.Scripts {
    public class CheckForInteraction : MonoBehaviour {

        private bool inConversation;

        private Text dialog;

        private GameObject paskavittu;

        public static List<string> dialogs = new List<string>();

        void Start() {

            DialogScript.DialogInit();

            dialog = GameObject.Find("ShowDialog/DialogBox").GetComponent<Text>();

        }

        

        void OnTriggerEnter2D(Collider2D colli) {

            if (colli.CompareTag("NPC")) {

                dialog.text = DialogScript.getDialog(int.Parse(colli.gameObject.name));
                
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