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

    // the Mount

    public string theMount;

    public GameObject inputFieldTheMount;

    public GameObject textDisplayTheMount;

    public void StoreAll()
    {

        // the Line

        theLine = inputFieldTheLine.GetComponent<Text>().text;

        int.TryParse(inputFieldTheLine.GetComponent<Text>().text, out int donggido);

        AAA.Instance.sodong = donggido;

        Debug.Log("Số dòng: " + donggido);

        textDisplayTheLine.GetComponent<Text>().text = "Line " + theLine;

        // the Collum

        theCollum = inputFieldTheCollum.GetComponent<Text>().text;

        int.TryParse(inputFieldTheCollum.GetComponent<Text>().text, out int cotgido);

        AAA.Instance.socot = cotgido;

        Debug.Log("Số cột: " + cotgido);

        textDisplayTheCollum.GetComponent<Text>().text = "Col: " + theCollum;

        // the Mount

        theMount = inputFieldTheMount.GetComponent<Text>().text;

        int.TryParse(inputFieldTheMount.GetComponent<Text>().text, out int khoigido);

        AAA.Instance.sokhoi = khoigido;

        Debug.Log("Số khối: " + khoigido);

        textDisplayTheMount.GetComponent<Text>().text = "Mount: " + theMount;



        //Load Scene
        SceneManager.LoadScene("GameScene");
    }

    public void checkBtnGO()
    {
        // check điều kiện input số dòng, số cột, số khối không được âm ( !< 0 ) và != null 

        if (inputFieldTheLine == null && inputFieldTheCollum == null && inputFieldTheMount == null)
        {
            if (AAA.Instance.socot < 0 && AAA.Instance.sodong < 0 && AAA.Instance.sodong < 0)

                Debug.LogWarning("Số cột, số hàng, số khối không được < 0");

            Debug.LogWarning("Số cột, số hàng, số khối không được để trống");

        }
    }
}
