using UnityEngine;
using System.Collections;


namespace Assets.Scripts {
    public class CheckForInteraction : MonoBehaviour {

        void OnTriggerEnter2D(Collider2D colli) {

            if (colli.CompareTag("NPC") == true) {

                GameObject.Find("ShowDialog").GetComponent<DisplayDialog>().showDialog(npcDialogs.getDialog(colli.gameObject.name));

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