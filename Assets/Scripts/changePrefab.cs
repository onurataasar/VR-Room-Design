using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePrefab : MonoBehaviour
{

    public GameObject prefab1;

    public GameObject prefab2;
    public int i = 0;
    // Start is called before the first frame update
    public void Start()
    {
        prefab1.gameObject.SetActive(true);
        prefab2.gameObject.SetActive(false);


        if (i == 0)
        {
            prefab1.gameObject.SetActive(false);
            prefab2.gameObject.SetActive(true);
        }
        if (i == 1)
        {
            prefab1.gameObject.SetActive(true);
            prefab2.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void change_Prefab()
    {
 
        i = i + 1;
        if (i == 2)
        {
            i = 0;
        }
        Debug.Log(i);

    }
}
