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

        string playerName;
        int Intelligence;
        int Charisma;
        int Strength;
        int Luck;

        public int HoboCoinsCollected = 0;

        int Health;


        public Player(string playerName, int Int, int Char, int Str, int Lck) {

            this.playerName = playerName;

            this.HoboCoinsCollected = 0;

            this.Intelligence = Int;
            this.Charisma = Char;
            this.Strength = Str;
            this.Luck = Lck;

            this.Health = 10;

        }

        public void GetHoboCoin() {

            HoboCoinsCollected++;

        }

        public void ReceiveDamage(int amount) {

            this.Health -= amount;

        }

        public void HealPlayer() {

            this.Health = 10;

        }

        public void SetStats(int Int, int Char, int Str, int Lck) {

            this.Intelligence = Int;
            this.Charisma = Char;
            this.Strength = Str;
            this.Luck = Lck;

            }



        }

    }
