using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AccelerometerInput : MonoBehaviour {
    //GUIText myText;
    Text myText;
	// Use this for initialization
	void Start () {
        //myText.text = "Start()";
        myText = GetComponent<Text>();
            }
	
	// Update is called once per frame
	void Update () {
        //GameObject.Find("AccelerometerText").GetComponent<GUIText>().text = "I am the test text from the scrtip!";
        switch (myText.name)
        {
            case "AccX":
                myText.text = "X = " + Mathf.Round(Input.acceleration.x * 100f) / 100f;
                break;

            case "AccY":
                myText.text = "Y = " + Mathf.Round(Input.acceleration.y * 100f) / 100f;
                break;

            case "AccZ":
                myText.text = "Z = " + Mathf.Round(Input.acceleration.z * 100f) / 100f;
                break;   
        }
    }
}
