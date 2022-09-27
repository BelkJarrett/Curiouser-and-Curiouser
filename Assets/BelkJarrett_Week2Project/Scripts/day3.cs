using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{

    /*    [SerializeField]
        bool blightswitch = true;

        // Use this for initialization
        void Start()
        {

        }
        // Update is called once per frame
        void Update()
        {
            //if (blightswitch == true)
            if (blightswitch)
            {
                Debug.Log("The light is on.");
            }
            else
            {
                Debug.Log("The light is off.");
            }
        }*/
    /*    [SerializeField]
        bool bGameOver;

        void Update()
        {
            //if (bGameOver== false)
            if (!bGameOver)
            {
                Debug.Log("playing");
            }
            else
            {
                Debug.Log("Not playing.");
            }
        }*/
    [SerializeField]
    bool bToggle = false;

    void Update()
    {
        bToggle = Invert(bToggle);
        Debug.Log("bToggle is:" + bToggle);
    }

    bool Invert(bool bValue)
    {
        return !bValue;
    }
}    

      
