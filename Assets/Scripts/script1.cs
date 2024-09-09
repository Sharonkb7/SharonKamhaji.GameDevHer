using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
// give better name
public class script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyIntMethod(12);
        // methods should be CamelCase - IfMyInt()
        ifMyInt(11);
        switchMyInt(3);
    }  
    
    /* 
     CONFESSION -  i think i didnt got the logic of methods that returns data or the void ones
     I hope I made the task in a way that makes sense
    */
        
    int MyIntMethod(int value)
    {
    value = value / 3;
    Debug.Log(value);
    return value;
    }

    bool ifMyInt(int value)
    {
    // value is a saved c# keyword, try use a diffrent name for this variable
        if (value > 10)
        {
            Debug.Log("this number is smaller than ten");
            return false;
        }
        else
        {
            Debug.Log("THIS NUMBER GREATER THAN TEN");
            return true;
        }

    }
// method name should be CamelCase
     public void switchMyInt (int value)
        {
            switch (value)
            {
                case 1:
                    {
                        Debug.Log("this number is 1");
                        break;
                    }


                case 2:
                    {
                        Debug.Log("this number is 2");
                        break;
                    }

                case 3:
                    {
                        Debug.Log("this number is 3");
                        break;
                    }
            }
        }
    }








