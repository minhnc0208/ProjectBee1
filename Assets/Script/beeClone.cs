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

        CreateBee(5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateBee(int beesNum)
    {
        for(int  i = 0; i<beesNum; i++)
        {
            GameObject BeeClone = Instantiate(beeOriginal, new Vector3(i*1.8f, beeOriginal.transform.position.y*1), 
                beeOriginal.transform.rotation);

            //BeeClone.transform.parent = beeContainer.transform;

            BeeClone.name = "BeeClone" + (i + 1);
        }
    }
}
