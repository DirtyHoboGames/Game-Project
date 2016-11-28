using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Assets;
using Assets.Scripts;
using UnityEngine.SceneManagement;

public class WenchLineofSight : MonoBehaviour {
    private Text dialog;
    private GameObject WenchStoryWindow;
    private Button YesButton;
    private Button NoButton;
    

    void Start() {
        WenchStoryWindow = GameObject.Find("WenchStoryWindow");
        YesButton = GameObject.Find("WenchStoryWindow/YesButton").GetComponent<Button>();
        NoButton = GameObject.Find("WenchStoryWindow/NoButton").GetComponent<Button>();

        YesButton.onClick.AddListener(() => YesButtonClicked());
        NoButton.onClick.AddListener(() => NoButtonClicked());

        DialogScript.DialogInit();
        dialog = GameObject.Find("ShowDialog/DialogBox").GetComponent<Text>();
        WenchStoryWindow.SetActive(false);

    }
    void YesButtonClicked() {
        hideStory();
        InventoryHandler.GiveRose();
        
        
    }
    void NoButtonClicked() {
        hideStory();
        StatKeeper.receiveDamage(6);
        SceneManager.LoadScene(4);
    }

    void showStory() {
        WenchStoryWindow.SetActive(true);

    }


    void hideStory() {

        WenchStoryWindow.SetActive(false);

    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.CompareTag("Playa")) { //if player hits the collider, time freezes and dialogue follows.
            //Time.timeScale = 0f;
            showStory();
            Debug.Log("lel");
        }
    }
}
