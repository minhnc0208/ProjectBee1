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

        // tạo list kết quả chứa int = Những đối tượng xung quanh của con số đó
        // foreach của 1 item trong kết quả => Log => item ( con số ).

        List<int> result = FindNearby(45);

        foreach (var item in result)
        {
            Debug.Log(item);
        }



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

    //ham => truyen vao param int => kq return 1 list(int)

    // int beeAll thay dc 5 thang xung quanh

    // tạo hàm rồi truyền vào param có kiểu dữ liệu int => trả về kết quả 1 list ( chứa int ).
    List<int> CreateNew(int beeAll)
    {
        List<int> beeInt = new List<int>();

        CreateAll(AAA.Instance.socot, AAA.Instance.sodong);

        return beeInt;
    }
    // tạo mảng 2 chiều 

    public void CreateAll(int beesNum, int bees2Num)
    {
        // truyền 2 tham số vào mảng 2 chiều và khai báo GO

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

                }

                else
                {
                    Debug.Log("parent not instantiate");
                }
            }

        }

    }


    // tạo List chứa int với ý nghĩa FindNearBy => tạo thêm List chứa int với định nghĩa những cục tổ ong ở gần
    List<int> FindNearby(int index)
    {
        List<int> nearby = new List<int>();

        // Bên trái
        int trai = index - 1;
        // Bên phải
        int phai = index + 1;
        // Bên trên của bên trái
        int tren1 = index + AAA.Instance.socot;
        // Bên trên của bên phải
        int tren2 = index + AAA.Instance.socot + 1;
        // Bên dưới của bên trái
        int duoi1 = index - AAA.Instance.socot;
        // Bên dưới của bên phải
        int duoi2 = index - AAA.Instance.socot + 1;

        // check số bên trái có hợp lệ hay ko => Nếu hợp lệ, thì add số bên trái <=> Nếu không hợp lệ, thì không add số bên trái

        if (IsValidNumber(trai))
        {
            nearby.Add(trai);
        }

        // check số bên phải có hợp lệ hay ko => Nếu hợp lệ, thì add số bên phải <=> Nếu không hợp lệ, thì không add số bên phải

        if (IsValidNumber(phai))
        {
            nearby.Add(phai);
        }

        // check số bên trên của bên trái có hợp lệ hay ko 
        // => Nếu hợp lệ, thì add số bên trên của bên trái <=> Nếu không hợp lệ, thì không add số bên trên của bên trái

        if (IsValidNumber(tren1))
        {
            nearby.Add(tren1);
        }

        // check số bên trên của bên phải có hợp lệ hay ko 
        // => Nếu hợp lệ, thì add số bên trên của bên phải <=> Nếu không hợp lệ, thì không add số bên trên của bên phải

        if (IsValidNumber(tren2))
        {
            nearby.Add(tren2);
        }

        // check số bên dưới của bên trái có hợp lệ hay ko 
        // => Nếu hợp lệ, thì add số bên dưới của bên trái <=> Nếu không hợp lệ, thì không add số bên dưới của bên trái

        if (IsValidNumber(duoi1))
        {
            nearby.Add(duoi1);
        }

        // check số bên dưới của bên phải có hợp lệ hay ko 
        // => Nếu hợp lệ, thì add số bên dưới của bên phải <=> Nếu không hợp lệ, thì không add số bên dưới của bên phải 

        if (IsValidNumber(duoi2))
        {
            nearby.Add(duoi2);
        }

        // trả về những đối tượng ở gần
        return nearby;
    }

    // xác định số hợp lệ ( loại bỏ được số âm, loại bỏ được những số bên góc )
    bool IsValidNumber(int index)
    {

        return true;
    }

}
