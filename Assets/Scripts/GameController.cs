using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;

namespace Assets.Scripts {
    public class GameController : MonoBehaviour {


        private ButtonController upButton;
        private ButtonController downButton;
        private ButtonController rightButton;
        private ButtonController leftButton;
        private GameObject Player;
        private GameObject Map;
        private Button mapButton;
        private Button bagButton;
        private GameObject Bag;
        private Text HoboCoin;

        // Initialize all the game components necessary to control the player object and inventory, map etc.
        void Start() {

            Player player = new Player("Player", 3, 4, 5, 6);

            downButton = GameObject.Find("ButtonDown").GetComponent<ButtonController>();        //  Controls
            upButton = GameObject.Find("ButtonUp").GetComponent<ButtonController>();            //  the
            rightButton = GameObject.Find("ButtonRight").GetComponent<ButtonController>();      //  players
            leftButton = GameObject.Find("ButtonLeft").GetComponent<ButtonController>();        //  movement & uses ButtonController class

            Bag = GameObject.Find("Bag");                                                       // Initializes the Inventory
            mapButton = GameObject.Find("ButtonMap").GetComponent<Button>();                    //   hides/shows map image. Uses a button method instead of ButtonController.
            Map = GameObject.Find("MapController");
            bagButton = GameObject.Find("ButtonBag").GetComponent<Button>();

            Player = GameObject.Find("Player");                                               // playable character

            mapButton.onClick.AddListener(() => toggleMap());                                   // Calls a method on mouse click/touch input to hide/show minimap of the current scene
            bagButton.onClick.AddListener(() => toggleInventory());                             // Calls a toggleInventory method to hide/show player's inventory

            preventUIOverlap();
        }
        
        // Waits for a user input to move the character into appropriate direction.
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

        public void MovePlayer(string direction) {                 //Method for moving the player character

            if (direction.Equals("up")) {
                Player.transform.Translate(0, 0.02f, 0);
            }
            if (direction.Equals("down")) {
                Player.transform.Translate(0, -0.02f, 0);
            }
            if (direction.Equals("left")) {
                Player.transform.Translate(-0.02f, 0, 0);
            }
            if (direction.Equals("right")) {
                Player.transform.Translate(0.02f, 0, 0);
            }
        }

        private void toggleMap() {          //Method for showing/hiding minimap of the current scene

            preventUIOverlap();             //Hiding other menus in order to avoid them overlapping

            if (Map.activeSelf == true) {

                Map.SetActive(false);

            }
            else {

                Map.SetActive(true);

            }
        }

        public void toggleInventory() {

            preventUIOverlap();             //Hiding other menus in order to avoid them overlapping

            if (Bag.activeSelf == true) {

                Bag.SetActive(false);

            }
            else {

                Bag.SetActive(true);

            }
        }

        public void preventUIOverlap() {           //This method just disables all menus in order to prevent overlapping

            Bag.SetActive(false);
            Map.SetActive(false);

        }

    }
}