using UnityEngine;
using System.Collections;

namespace Assets.Scripts {
    public static class StatKeeper {


        static int Health;
        static int Charisma;
        static int Strength;
        static int Intelligence;
        static int Luck;

        static int HoboCoinsCollected;

        public static void setStats(int health, int str, int chr, int Int, int lck) {

            Debug.Log("Setting stats for player");

            Health = health;

            Strength = str;
            Charisma = chr;
            Intelligence = Int;
            Luck = lck;

        }

        public static void receiveDamage(int amount) {

            Debug.Log("Player receives damage for" + amount + " points");
            Health -= amount;

        }

        public static void healPlayer() {

            Debug.Log("Healing player back to full health");
            Health = 10;

        }

        //Whenever player picks up a HoboCoin, this method is called
        public static void collectHoboCoin() {

            Debug.Log("Player found a HoboCoin !");

            HoboCoinsCollected++;

        }

        //Returns the amount of HoboCoins 
        public static int getCoinAmount() {

            return HoboCoinsCollected;

        }

        //Returns player's health
        public static int getHealth() {

            return Health;
        }

        //Collects all of the stats into a string, which is displayed in the stats window on UI
        public static string getStats() {

            string temp = "" +

                            "Health   " + Health + "\r\n\r\n" +
                            "Strength   " + Strength + "\r\n" +
                            "Charisma   " + Charisma + "\r\n" +
                            "Intelligence   " + Intelligence + "\r\n" +
                            "Luck   " + Luck + "\r\n" +
                            "HoboCoins found    " + HoboCoinsCollected;

            return temp;

        }
    }
}
