using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine.UI;

namespace Assets.Scripts {
    public class DialogScript : MonoBehaviour {
        public Text DialogBox;

        public static List<string> dialogs = new List<string>();

        void Start() {


            DialogBox = GameObject.Find("DialogBox").GetComponent<Text>();


            //mlady
            dialogs.Add("I haven't seen thee hither ere. Mine own name is m'lady. What is thy nameth?");
            dialogs.Add("Typeth thy nameth");
            dialogs.Add("Nice to meeteth thee x. I am new at this nurs'ry and t is at each moment nice to meeteth new people. ");

            //rival
            // dialogs.Add("At which hour thee heareth the bell, cometh apace. The bitter cold drizzle shall halt the bond driveth.");

            //other kid
            //dialogs.Add("Doth not disturb me");

            //father(s)
            //dialogs.Add("");
        }


        public static string CheckDialog(int Index) {
            string temp = dialogs[Index];

            return temp;
        }
    }
}
