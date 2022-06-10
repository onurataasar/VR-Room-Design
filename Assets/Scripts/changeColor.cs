using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{

    public void change_color()
    {
        
            
            if (gameObject.GetComponent<Renderer>().material.color == Color.blue)
            {
            
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (gameObject.GetComponent<Renderer>().material.color == Color.yellow)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }

            else if (gameObject.GetComponent<Renderer>().material.color == Color.red)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.black;
            }

            else if (gameObject.GetComponent<Renderer>().material.color == Color.black)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }

        





    }
}