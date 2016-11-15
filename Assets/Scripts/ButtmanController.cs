using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;

namespace Assets.Scripts {
    public class ButtmanController : MonoBehaviour {

        private ButtonController upButton;
        private ButtonController downButton;
        private ButtonController rightButton;
        private ButtonController leftButton;
        private GameObject Buttman;
        private GameObject Map;
        private Button mapButton;

        void Start() {

            downButton = GameObject.Find("ButtonDown").GetComponent<ButtonController>();        //  Controls
            upButton = GameObject.Find("ButtonUp").GetComponent<ButtonController>();            //  the
            rightButton = GameObject.Find("ButtonRight").GetComponent<ButtonController>();      //  players
            leftButton = GameObject.Find("ButtonLeft").GetComponent<ButtonController>();        //  movement & uses ButtonController class

            mapButton = GameObject.Find("ButtonMap").GetComponent<Button>(); //   hides/shows map image. Uses a button method instead of ButtonController.
            Map = GameObject.Find("MapController");
            Buttman = GameObject.Find("Buttman");                                       // playable character

            mapButton.onClick.AddListener(() => toggleMap());                           // Calls a method on mouse click/touch input to hide/show minimap of the current scene

        }

        void Update() {
            if (upButton.GetPressed()) {
                MovePlayer("up");
            }
            if (downButton.GetPressed()) {
                MovePlayer("down");
            }
            if (rightButton.GetPressed()) {
                MovePlayer("right");
            }
            if (leftButton.GetPressed()) {
                MovePlayer("left");
            }


        }

        void MovePlayer(string direction) {                 //Method for moving the player character

            if (direction.Equals("up")) {
                Buttman.transform.Translate(0, 0.02f, 0);
            }
            if (direction.Equals("down")) {
                Buttman.transform.Translate(0, -0.02f, 0);
            }
            if (direction.Equals("left")) {
                Buttman.transform.Translate(-0.02f, 0, 0);
            }
            if (direction.Equals("right")) {
                Buttman.transform.Translate(0.02f, 0, 0);
            }
        }

        private void toggleMap() {          //Method for showing/hiding minimap of the current scene

            if(Map.activeSelf == true) {

                Map.SetActive(false);

                } else {

                Map.SetActive(true);

                }
            }

        }
    }