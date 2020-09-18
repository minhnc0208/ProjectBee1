using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class beeClone : MonoBehaviour
{

    public GameObject beeOriginal;

    public GameObject beeContainer;

    public GameObject toong;




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

        for (int i = 0; i < beesNum; i++)
        {
            for (int j = 0; j < bees2Num; j++)
            {
                // check xem đó là hàng lẻ hay chẵn => Nếu là hàng 1, 3, 5, 7 ( hàng lẻ ) !%2 thì else và <=>
                if (i % 2 == 0)
                {
                    // hàng chẵn
                    GameObject BeeClone2 = Instantiate(toong, new Vector3(j * 28.9f, i * 23f),
                               toong.transform.rotation, beeContainer.transform);
                    BeeClone2.name = "BeeClone2" + (j + 1);
                    BeeClone2.GetComponentInChildren<Text>().text = i.ToString();


                }
                else
                {
                    // hàng sole



                    //GameObject BeeClone = Instantiate(beeOriginal, new Vector3(j * 1.7f - 0.87f, i * 1.3f),
                    //                   beeOriginal.transform.rotation);
                    //BeeClone.name = "BeeClone" + (i + 1);

                    GameObject BeeClone = Instantiate(toong, new Vector3(j * 28.9f - 14f, i * 23f),
                               toong.transform.rotation, beeContainer.transform);
                    BeeClone.name = "BeeClone" + (j + 1);
                    BeeClone.GetComponentInChildren<Text>().text = i.ToString();

                }

            }

        }

    }


}
