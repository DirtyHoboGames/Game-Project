using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogScript : MonoBehaviour {

    Dictionary<string, string> dialogs =  new Dictionary<string,string >();


    void Start () {
        //mlady
        dialogs.Add("mlady1", "I haven't seen thee hither ere. Mine own name is m'lady. What is thy nameth?");
        dialogs.Add("mlady2", "Typeth thy nameth");
        dialogs.Add("mlady3", "Nice to meeteth thee x. I am new at this nurs'ry and t is at each moment nice to meeteth new people. ");

        //rival
        dialogs.Add("rival1", "At which hour thee heareth the bell, cometh apace. The bitter cold drizzle shall halt the bond driveth.");
        
        //other kid
        dialogs.Add("kid", "Doth not disturb me");

        //father(s)
        dialogs.Add("", "");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public string CheckDialog(string key) {
        string temp = "";
        if (dialogs.ContainsKey(key)){
            temp = dialogs[key];
        } else {
            temp = "null";
        }
        return temp;
    }
}
