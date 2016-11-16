using UnityEngine;
using System.Collections;

namespace Assets.Scripts {
    public class StatsManager : MonoBehaviour {

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

        // Update is called once per frame
        void Update() {

        }
            
        public void setStats(int Int, int Char, int Str, int Lck) {

            Intelligence = Int;
            Charisma = Char;
            Strength = Str;
            Luck = Lck;

        }

        public void setName(string name) {

            playerName = name;

        }

        public void CollectCoin() {

            HoboCoinsCollected ++;

        }
    }
}
