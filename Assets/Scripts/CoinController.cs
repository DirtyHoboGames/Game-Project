using UnityEngine;
using System.Collections;
using Assets.Scripts;

namespace Assets.Scripts { 
    class CoinController : MonoBehaviour {

        private GameObject ShowStats;

        //When Player touches the HoboCoin, it disappears and calls a method to add one HoboCoin into the collectables
	    void OnTriggerEnter2D(Collider2D colli) {

            ShowStats = GameObject.Find("ShowStats");

            DestroyObject(this.gameObject);

            StatKeeper.collectHoboCoin();

            Debug.Log(StatKeeper.getCoinAmount());

            ShowStats.SetActive(false);
            StatKeeper.DisplayStats();
            ShowStats.SetActive(true);

        }
	}
}
