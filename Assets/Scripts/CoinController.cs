using UnityEngine;
using System.Collections;
using Assets.Scripts;

namespace Assets.Scripts { 
public class CoinController : MonoBehaviour {

	    void OnTriggerEnter2D(Collider2D colli) {

            DestroyObject(this.gameObject);

            GameObject.Find("StatsManager").GetComponent<StatsManager>().CollectCoin();

            GameObject.Find("StatsManager").GetComponent<Player>().GetHoboCoin();

        }
	}
}
