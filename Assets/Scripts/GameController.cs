using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;

namespace Assets.Scripts {
    public class GameController : MonoBehaviour {

        public static GameController instance= null;
        private GameObject Player;
        private GameObject playerStats;
        private GameObject Map;
        private Button mapButton;
        private Button bagButton;
        private Button statsButton;
        private GameObject Stats;
        private GameObject Bag;
        public Player player;
        private Text statsText;
       

        // Initialize all the game components necessary to control the player object and inventory, map etc.
        void Awake() {

            if (instance == null) {
                instance = this;
            } else if (instance != this) {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);

            Player player = new Player("Player", 3, 4, 5, 6);

            StatKeeper.setStats(10, 3, 4, 5, 6);

            Bag = GameObject.Find("Bag");                                                       // Initializes the Inventory
            mapButton = GameObject.Find("ButtonMap").GetComponent<Button>();                    //   hides/shows map image. Uses a button method instead of ButtonController.
            Map = GameObject.Find("MapController");
            bagButton = GameObject.Find("ButtonBag").GetComponent<Button>();
            Stats = GameObject.Find("ShowStats");
            statsButton = GameObject.Find("ButtonStats").GetComponent<Button>();
            statsText = GameObject.Find("Stats").GetComponent<Text>();
            Debug.Log(player);

            Player = GameObject.Find("Player");                                               // playable character

            statsButton.onClick.AddListener(() => toggleStats());                               // Calls a method to display stats window on UI
            mapButton.onClick.AddListener(() => toggleMap());                                   // Calls a method on mouse click/touch input to hide/show minimap of the current scene
            bagButton.onClick.AddListener(() => toggleInventory());                             // Calls a toggleInventory method to hide/show player's inventory

            preventUIOverlap();

            Debug.Log(player.DisplayStats());

        }

        
        // Waits for a user input to move the character into appropriate direction.
        void Update() {     

        }

        /* public void CollectCoin() {

            Debug.Log("Now trying to use the player instance");
            player.CollectHoboCoin();

        } */


        //displays Minimap window on UI
        private void toggleMap() {                  //Method for showing/hiding minimap of the current scene

            preventUIOverlap();             //Hiding other menus in order to avoid them overlapping

            if (Map.activeSelf == true) {

                Map.SetActive(false);
                statsText.text = StatKeeper.DisplayStats();
            }
            else {

                Map.SetActive(true);

            }
        }

        //Displays Inventory window on UI
        private void toggleInventory() {

            preventUIOverlap();             //Hiding other menus in order to avoid them overlapping

            if (Bag.activeSelf == true) {

                Bag.SetActive(false);

            }
            else {

                Bag.SetActive(true);

            }
        }

        // Displays Stats window on UI
       private void toggleStats() {

            preventUIOverlap();                 //Hiding other menus in order to avoid them overlapping

            if (Stats.activeSelf == false) {

                Stats.SetActive(true);
                statsText.text = StatKeeper.DisplayStats();


            } else {

                Stats.SetActive(false);

            }

        }

        public void preventUIOverlap() {           //This method just disables all menus in order to prevent overlapping

            if (Bag.activeSelf == true) {
                Bag.SetActive(false);
            }

            if (Map.activeSelf == true) {
                Map.SetActive(false);
            }

            if (Stats.activeSelf == true) {
                Stats.SetActive(false);



            }
        }
    }
}