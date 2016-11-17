using UnityEngine;
using System.Collections;
using Assets.Scripts;

namespace Assets.Scripts { 
    class CoinController : MonoBehaviour {

        //When Player touches the HoboCoin, it disappears and calls a method to add one HoboCoin into the collectables
	    void OnTriggerEnter2D(Collider2D colli) {

            DestroyObject(this.gameObject);

            GameObject.Find("StatsManager").GetComponent<Player>().GetHoboCoin();

        }
	}
}
