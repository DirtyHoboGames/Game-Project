using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts {
    class Player : MonoBehaviour {

        // Make this game object and all its transform children
        // survive when loading a new scene.
        void Awake() {
            DontDestroyOnLoad(this);
        }

        //Create variables for different stats and Collectables
        string playerName;
        int Intelligence;
        int Charisma;
        int Strength;
        int Luck;

        public int HoboCoinsCollected = 0;

        int Health;

        //Constructor for a Player object
        public Player(string playerName, int Int, int Char, int Str, int Lck) {

            this.playerName = playerName;

            this.HoboCoinsCollected = 0;

            this.Intelligence = Int;
            this.Charisma = Char;
            this.Strength = Str;
            this.Luck = Lck;

            this.Health = 10;

        }

        //This method adds one collectable into HoboCoinsCollected Integer variable
        public void GetHoboCoin() {

            Debug.Log("Player found a HoboCoin !");

            HoboCoinsCollected++;

        }

        //This method makes our hero get slapped in the face and deals damage for an appropriate amount
        public void ReceiveDamage(int amount) {

            Debug.Log("An enemy dealt damage to Player !");

            this.Health -= amount;

        }

        //This method heals our hero back to full health, so he can keep on getting his ass kicked
        public void HealPlayer() {

            Debug.Log("Healing Player back to full health");

            this.Health = 10;

        }

        //This method sets our hero's Attributes, so he can get his ass kicked in a number of different ways
        public void SetStats(int Int, int Char, int Str, int Lck) {

            this.Intelligence = Int;
            this.Charisma = Char;
            this.Strength = Str;
            this.Luck = Lck;

            }
        }
    }
