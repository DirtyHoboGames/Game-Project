
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class DialogScript {

        private static List<string> dialogs = new List<string>();
        

        public static void DialogInit() {


            //M' Lady 0-2
            dialogs.Add("M' Lady \r\n   I haven't seen thee hither ere. What is thy nameth?");
            dialogs.Add("M' Lady \r\n   Typeth thy nameth");
            dialogs.Add("M' Lady \r\n   Nice to meeteth thee x. I am new at this nurs'ry and t is at each moment nice to meeteth new people. ");
            
            //rival 3
            dialogs.Add("At which hour thee heareth the bell, cometh apace. The bitter cold drizzle shall halt the bond driveth.");

            //other kid 4
            dialogs.Add("Doth not disturb me");

            //Computer??!!!??! 5
            dialogs.Add("No mitä vittua ? ekkö oo \r\n enne nähny puhuvaa konetta ?");

            //father(s) 6-jotain
            dialogs.Add("");

        }

        public static string getDialog (int lel) {

            if(dialogs.Count > lel) {
            return dialogs[lel];

        } else {

            return "not found";

        }
    }
}
}
