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

    // the row
    //public string theRow;

    //public GameObject inputFieldTheRow;

    //public GameObject textDisplayTheRow;

    public void StoreAll()
    {
        // the Line

        theLine = inputFieldTheLine.GetComponent<Text>().text;

        int.TryParse(inputFieldTheLine.GetComponent<Text>().text, out int donggido);

        AAA.Instance.sodong = donggido;

        Debug.Log(donggido);

        textDisplayTheLine.GetComponent<Text>().text = "Line " + theLine;

        // the Collum

        theCollum = inputFieldTheCollum.GetComponent<Text>().text;

        int.TryParse(inputFieldTheCollum.GetComponent<Text>().text, out int cotgido);

        AAA.Instance.socot = cotgido;

        Debug.Log(cotgido);

        textDisplayTheCollum.GetComponent<Text>().text = "Col: " + theCollum ;

        

        // the Row

        //theRow = inputFieldTheRow.GetComponent<Text>().text;

        //int.TryParse(inputFieldTheRow.GetComponent<Text>().text, out int hanggido);

        //AAA.Instance.sohang = hanggido;

        //Debug.Log(hanggido);

        //textDisplayTheRow.GetComponent<Text>().text = "Row " + theRow;

        //Load Scene
        SceneManager.LoadScene("GameScene");

    }

  


}
