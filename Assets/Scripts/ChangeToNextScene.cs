using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Assets.Scripts {
    public class ChangeToNextScene : MonoBehaviour {

        void OnTriggerEnter2D(Collider2D col) {

            Debug.Log("Player triggered level change");

            int currentScene = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currentScene + 1);


        }
    }
}
