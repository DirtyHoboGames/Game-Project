using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets.Scripts;
using UnityEngine.SceneManagement;

namespace Assets.Scripts {
    public class GameController : MonoBehaviour {

        public static GameController instance= null;
        private GameObject Player;
        private GameObject playerStats;
        private GameObject Map;
        private Button menuButton;
        private Button mapButton;
        private Button bagButton;
        private Button statsButton;
        private Button enterButton;
        private Button menuPlayButton;
        private Button menuQuitButton;
        private GameObject Stats;
        private GameObject Bag;
        private GameObject DialogToggle;
        private GameObject Menu;

        public Player player;

        private Text statsText;
        private Text dialogText;

        private GameObject Interact;
       

        // Initialize all the game components necessary to control the player object and inventory, map etc.
        void Awake() {

            if (instance == null) {
                instance = this;
            } else if (instance != this) {
                Destroy(gameObject);
            }

            //DontDestroyOnLoad(gameObject);

            Player player = new Player("Player", 3, 4, 5, 6);

            StatKeeper.setStats(10, 3, 4, 5, 6);

            enterButton = GameObject.Find("ButtonEnter").GetComponent<Button>();
            Bag = GameObject.Find("Bag");                                                       // Initializes the Inventory
            mapButton = GameObject.Find("ButtonMap").GetComponent<Button>();                    //   hides/shows map image. Uses a button method instead of ButtonController.
            Map = GameObject.Find("MapController");
            bagButton = GameObject.Find("ButtonBag").GetComponent<Button>();
            Stats = GameObject.Find("ShowStats");
            statsButton = GameObject.Find("ButtonStats").GetComponent<Button>();
            statsText = GameObject.Find("Stats").GetComponent<Text>();
            DialogToggle = GameObject.Find("ShowDialog");                                     //This object(ShowDialog) controls the dialog box
            dialogText = GameObject.Find("ShowDialog").GetComponent<Text>();               //This is the dialog box's text
            Interact = GameObject.Find("Player/Interact");
            menuButton = GameObject.Find("ButtonMenu").GetComponent<Button>();
            menuPlayButton = GameObject.Find("ShowMenu/ResumeButton").GetComponent<Button>();
            menuQuitButton = GameObject.Find("ShowMenu/QuitButton").GetComponent<Button>();               
            Menu = GameObject.Find("ShowMenu");                                       //this object toggles the pause menu

            Player = GameObject.Find("Player");                                               // playable character

            statsButton.onClick.AddListener(() => toggleStats());                               // Calls a method to display stats window on UI
            mapButton.onClick.AddListener(() => toggleMap());                                   // Calls a method on mouse click/touch input to hide/show minimap of the current scene
            bagButton.onClick.AddListener(() => toggleInventory());                             // Calls a toggleInventory method to hide/show player's inventory
            enterButton.onClick.AddListener(() => searchInteraction());
            menuButton.onClick.AddListener(() => toggleMenu());
            menuPlayButton.onClick.AddListener(() => resumeGame());
            menuQuitButton.onClick.AddListener(() => SceneManager.LoadScene(1));

            preventUIOverlap();

            cancelInteracting();

            Debug.Log(player.DisplayStats());

        }

        
        // Waits for a user input to move the character into appropriate direction.
        void Update() {     

        }

        //This allows user to interact with the environment
        private void searchInteraction() {

            Debug.Log("Player pressed Enter");

            Interact.SetActive(true);
            Invoke("cancelInteracting", 1);     //Waits for 1 second and then turns the interaction trigger off. 

        }

        private void cancelInteracting() {

            Interact.SetActive(false);

        }

        //This method toggles the pause menu
        private void toggleMenu() {

            Debug.Log("Menu toggle");
            preventUIOverlap();

            if (Menu.activeSelf == true) {

                Menu.SetActive(false);

            } else {

                Time.timeScale = 0f;
                Menu.SetActive(true);

            }

        }

        // This method resumes gameplay in pause menu
        private void resumeGame() {

            Time.timeScale = 1f;
            preventUIOverlap();

        }

        //displays Minimap window on UI
        private void toggleMap() {                  //Method for showing/hiding minimap of the current scene

            Debug.Log("Map toggle");
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

            Debug.Log("Inventory toggle");
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

            Debug.Log("Stats toggle");
            preventUIOverlap();                 //Hiding other menus in order to avoid them overlapping

            if (Stats.activeSelf == false) {

                Stats.SetActive(true);
                statsText.text = StatKeeper.DisplayStats();


            } else {

                Stats.SetActive(false);

            }
        }

        //This method just disables all menus in order to prevent overlapping
        public void preventUIOverlap() {    

            if (Bag.activeSelf == true) {
                Bag.SetActive(false);
            }

            if (Map.activeSelf == true) {
                Map.SetActive(false);
            }

            if (Stats.activeSelf == true) {
                Stats.SetActive(false);
            }
            
            if(Menu.activeSelf == true) {
                 Menu.SetActive(false);

                }


            }
        }
    }