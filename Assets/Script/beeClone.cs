﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeClone : MonoBehaviour
{

    public GameObject beeOriginal;

    public GameObject beeContainer;

    // Start is called before the first frame update
    void Start()
    {
        // GameObject BeeClone = Instantiate(beeOriginal);

        //CreateBee(5);

        //CreateBee2(5);



        CreateBee(AAA.Instance.sodong);

        CreateBee2(AAA.Instance.socot);
    }

    private void CreateBee(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //số dòng
    void CreateBee(int beesNum)
    {
        for(int  i = 0; i <= beesNum ; i++)
        {
            GameObject BeeClone = Instantiate(beeOriginal, new Vector3(i* 1.7f, beeOriginal.transform.position.y*1), 
                beeOriginal.transform.rotation);

            BeeClone.name = "BeeClone" + (i + 1);
        }
    }

    // số cột
    void CreateBee2(int bees2Num)
    {
        for(int i = 0; i <= bees2Num; i++)
        {
            GameObject BeeClone2 = Instantiate(beeOriginal, new Vector3(i * 1.7f-0.87f, beeOriginal.transform.position.y+1.3f),
                beeOriginal.transform.rotation);

            BeeClone2.name = "BeeClone2" + (i + 1);
        }
    }

    
}
