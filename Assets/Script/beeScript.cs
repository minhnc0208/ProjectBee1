using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class beeScript : MonoBehaviour
{
    // the Line
    public string theLine;

    public GameObject inputFieldTheLine;

    public GameObject textDisplayTheLine;

    // the Collum
    public string theCollum;

    public GameObject inputFieldTheCollum;

    public GameObject textDisplayTheCollum;


    public void StoreAll()
    {
        theCollum = inputFieldTheCollum.GetComponent<Text>().text;

        textDisplayTheCollum.GetComponent<Text>().text = "Col: " + theCollum ;

        theLine = inputFieldTheLine.GetComponent<Text>().text;

        textDisplayTheLine.GetComponent<Text>().text = "Line " + theLine;


        // Load Scene

        //SceneManager.LoadScene("GameScene");
    }
}
