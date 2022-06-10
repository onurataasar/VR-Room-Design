using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;
    public Material Material5;

    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object;

    public int i = 0;
    public void Start()
    {

        Material[] myMaterials = new Material[5];
        myMaterials[0] = Material1;
        myMaterials[1] = Material2;
        myMaterials[2] = Material3;
        myMaterials[3] = Material4;
        myMaterials[4] = Material5;


        Object.GetComponent<MeshRenderer>().material = myMaterials[i];
    }



    // Update is called once per frame
    public void change_Material()
    {
        
    
        i = i + 1;
        if (i == 5)
        {
            i = 0;
        }
        Debug.Log(i);
        
    }

    
}
