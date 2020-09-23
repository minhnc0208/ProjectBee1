using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class beeClone : MonoBehaviour
{

    public GameObject beeOriginal;

    public GameObject beeContainer;

    public GameObject toong;

    public GameObject tongsokhoi;

    public Transform canvas;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject BeeClone = Instantiate(beeOriginal);

        //CreateBee(5);

        //CreateBee2(5);

        //CreateBee3(5);

        //CreateBee(AAA.Instance.sodong);


        //CreateBee2(AAA.Instance.socot);



        CreateAll(AAA.Instance.sodong, AAA.Instance.socot);

    }

    //private void CreateBee2(int socot)
    //{
    //    throw new NotImplementedException();
    //}


    private void CreateBee(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    //private GameObject CreateAll()
    //{
    //    throw new NotImplementedException();
    //}

    // Update is called once per frame
    void Update()
    {

    }

    //// số cục ngang
    //void CreateBee(int beesNum)
    //{
    //    for (int i = 0; i < beesNum; i++)
    //    {
    //        GameObject BeeClone = Instantiate(beeOriginal, new Vector3(i * 1.7f, beeOriginal.transform.position.y * 1),
    //            beeOriginal.transform.rotation);

    //        BeeClone.name = "BeeClone" + (i + 1);


    //    }
    //}

    //// số cục dọc
    //void CreateBee2(int bees2Num)
    //{
    //    for (int i = 0; i < bees2Num; i++)
    //    {

    //        // tạo vòng lặp cho hàng trên hàng dưới = số vòng tạo ra 

    //        GameObject BeeClone2 = Instantiate(beeOriginal, new Vector3(i * 1.7f - 0.87f, beeOriginal.transform.position.y + 1.3f),
    //            beeOriginal.transform.rotation);   

    //        BeeClone2.name = "BeeClone2" + (i + 1);

    //    }
    //}


    void CreateAll(int beesNum, int bees2Num)
    {
        int index = 0;

        GameObject goParent = null;

        for (int i = 0; i < beesNum; i++)
        {
            for (int j = 0; j < bees2Num; j++)
            {
                if (index % AAA.Instance.sokhoi == 0)
                {
                    goParent = Instantiate(tongsokhoi) as GameObject;

                    // set Parent trong Canvas
                    goParent.transform.SetParent(canvas);



                }

                index++;

                GameObject go;
                go = Instantiate(toong, beeContainer.transform);


                // check xem đó là hàng lẻ hay chẵn => Nếu là hàng 1, 3, 5, 7 ( hàng lẻ ) !%2 thì else và <=>
                if (i % 2 == 0)
                {
                    // hàng chẵn

                    go.GetComponent<RectTransform>().localPosition = new Vector3(j * 27.9f, i * 23.5f);

                    goParent.transform.SetParent(canvas);
                }
                else
                {
                    // hàng sole

                    //GameObject BeeClone = Instantiate(beeOriginal, new Vector3(j * 1.7f - 0.87f, i * 1.3f),
                    //                   beeOriginal.transform.rotation);
                    //BeeClone.name = "BeeClone" + (i + 1);


                    go.GetComponent<RectTransform>().localPosition = new Vector3(j * 27.9f - 13.5f, i * 23.5f);

                    goParent.transform.SetParent(canvas);

                }
                go.name = "BeeClone1" + (i * bees2Num + j + 1);

                go.GetComponentInChildren<Text>().text = (i * bees2Num + j + 1).ToString();



                if (goParent != null)
                {
                    go.transform.SetParent(goParent.transform);

                    goParent.name = "grpsokhoi" + (i * bees2Num + j + 1);

                    // grpsokhoi move to the position

                    //goParent.transform.localPosition = new Vector3(15f, 5f);


                    goParent.GetComponent<RectTransform>().localPosition = new Vector3(150f, 50f);
                }

                else
                {
                    Debug.Log("parent not instantiate");
                }
            }

        }

    }


}
