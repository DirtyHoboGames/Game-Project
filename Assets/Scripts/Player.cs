﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts {
    public class Player : MonoBehaviour {

        // Make this game object and all its transform children
        // survive when loading a new scene.
        void Awake() {
            DontDestroyOnLoad(this);
        }

        //Stores a player's name and Stats

        string playerName;
        public Text allStats;

        //Here are the different stats, which are saved as int variables
        int Intelligence;
        int Charisma;
        int Strength;
        int Luck;

        //Our fabulous collectibles, that are found throughout our vast in-game universe !
        public int HoboCoinsCollected = 0;

        //I think you can figure this out on your own
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
        public void GetHoboCoin(Player player) {

            Debug.Log("Player found a HoboCoin !");

            HoboCoinsCollected++;

            DisplayStats(player);

        }

        //This method makes our hero get slapped in the face and deals damage for an appropriate amount
        public void ReceiveDamage(Player player, int amount) {

            Debug.Log("An enemy deals damage for " + amount + " points" + "to Player !");

            this.Health -= amount;

            DisplayStats();

        }

        //This method heals our hero back to full health, so he can keep on getting his ass kicked
        public void HealPlayer(Player player) {

            Debug.Log("Healing Player back to full health");

            this.Health = 10;

            DisplayStats(player);

        }

        //This method sets our hero's Attributes, so he can get his ass kicked in a number of different ways
        public void SetStats(Player player, int Int, int Char, int Str, int Lck) {

            player.Intelligence = Int;
            player.Charisma = Char;
            player.Strength = Str;
            player.Luck = Lck;

            DisplayStats(player);

            }

        //Collects all of the stats into a string, which is displayed in the stats window on UI
        public void DisplayStats(Player player) {

                 allStats.text = 
                            "Health   " + player.Health + "\r\n\r\n" +
                            "Strength   " + player.Strength + "\r\n" +
                            "Charisma   " + player.Charisma + "\r\n" +
                            "Intelligence   " + player.Intelligence + "\r\n" +
                            "Luck   " + player.Luck + "\r\n" + 
                            "HoboCoins found    " + player.HoboCoinsCollected;

            }
        }
    }
