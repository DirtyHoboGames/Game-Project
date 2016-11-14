using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtmanController : MonoBehaviour {

    private ButtonController upButton;
    private ButtonController downButton;
    private ButtonController rightButton;
    private ButtonController leftButton;
    private GameObject Buttman;

    void Start() {
        downButton = GameObject.Find("ButtonDown").GetComponent<ButtonController>();
        upButton = GameObject.Find("ButtonUp").GetComponent<ButtonController>();
        rightButton = GameObject.Find("ButtonRight").GetComponent<ButtonController>();
        leftButton = GameObject.Find("ButtonLeft").GetComponent<ButtonController>();
        Buttman = GameObject.Find("Buttman");

        /*downButton.onClick.AddListener(() => MoveBall("down"));
        upButton.onClick.AddListener(() => MoveBall("up"));
        rightButton.onClick.AddListener(() => MoveBall("right"));
        leftButton.onClick.AddListener(() => MoveBall("left"));
        */
    }

    void Update() {
        if (upButton.GetPressed()) {
            MoveBall("up");
        }
        if (downButton.GetPressed()) {
            MoveBall("down");
        }
        if (rightButton.GetPressed()) {
            MoveBall("right");
        }
        if (leftButton.GetPressed()) {
            MoveBall("left");
        }


    }

    void MoveBall(string direction) {

        if (direction.Equals("up")) {
            Buttman.transform.Translate(0, 0.02f, 0);
        }
        if (direction.Equals("down")) {
            Buttman.transform.Translate(0, -0.02f, 0);
        }
        if (direction.Equals("left")) {
            Buttman.transform.Translate(-0.02f, 0, 0);
        }
        if (direction.Equals("right")) {
            Buttman.transform.Translate(0.02f, 0, 0);
        }
    }
}