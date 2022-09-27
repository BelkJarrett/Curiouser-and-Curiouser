using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BelkJarrett_Week2Project : MonoBehaviour
{
    Text screen;
    Page[] book;

    [SerializeField]
    string prevHeading;
    [SerializeField]
    string currHeading;
    [SerializeField]
    string nextHeading = "Enter Room";
   
    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.Find("MainText");

        if (go)
        {
            screen = go.GetComponent<Text>();

            if (!screen)
            {
                Debug.LogError("Text Component was not found on MainText");
            }
        }
        else
        {
            Debug.LogError("MainText not found");
        }

        //screen.text = "Hello Word";

        BindBook();
    }    
    
        // Update is called once per frame
    void Update()
    {
        HandleInput();
        RenderStory();
    }

    void BindBook()
    {
        book = new Page[]
        {
            new Page("Enter Room", "<b><i>(this is: Enter Room)</i></b>\nYou enter a room out of a Lewis Carrol story. " +
                "There is a table adorned with a tray of sweets, glasses of wine, and a solitary chair draped with a navy pea coat." +
                " Do you try the [S]weets, drink the [W]ine, or try on the [P]ea coat?"),

            new Page("Sweets", "<b><i>(this is: Sweets)</i></b>\nYou slink over to the table and snatch a powdered cover treat from the overflowing platter and pop it in your mouth. " +
                "You taste confectioner’s sugar and your first bite overwhelms you with chocolate cake and warm,  gooey fudge in the center." +
                "You savor the sweet pastry and seem to feel no ill effect from ingesting it. Press [X] to return to the previous step."),

            new Page("Wine", "<b><i>(this is: Wine)</i></b>\nYou slink over to the table, reaching out for one of the crystal goblets filled with light red wine. " +
                "You bring it close to your mouth, but before sipping it, you swirl it about sniffing the contents. " +
                "You wonder why you decided to do that aside from seeing people do it on TV.  " +
                "Though the thought of possible poisoning comes to mind, the wine smells like wine usually does. "+
                "You decide to take a sip of the wine and find it to be a savory grape juice and wonder how you mistook the scent of fermentation. + " +
                "Press [X] to return to the previous step."),

            new Page("Pea Coat", "<b><i>(this is: Pea Coat)</i></b>\nYou look at the peacoat draped over the single chair back and wonder whose it might be. " +
                "You reach out for it and feel the softest material.  " +
                "You look around you before pulling it off the chairback and putting it out in front of you, you notice the jacket is about your size. " +
                "The coat seems to be inviting you to try it on, do you [T]ry on the pea coat or press [X] to return."),

            new Page("Try On", "<b><i>(this is: Try On)</i></b>\nYou slip your arms into the peacoat, it sliding on like silk and feels like cashmere." +
                " here is something odd happening behind you as you button up the coat, it fits so perfectly." +
                " As you turn about, you see the table has disappeared and in its place are a gilded mirror on your left and an armoire on your right with a solitary hanger, you assume is for the coat." +
                "Though the coat is not yours, it wouldn’t hurt to admire yourself... " +
                "Though something is controlling the atmosphere and it may not take kindly to such a superficial want." +
                "Do you [G]rab a look in the mirror or attempt to replace the coat in the armoire and [L]eave?" +
                "Or press [X] to return to the previous step."),

            //win!
            new Page("Grab", "<b><i>(this is: Grab)</i></b>\nYou pour out all the contents onto the dusty floor, " +
                "You take a look in the mirror and it’s quite striking how amazing you look and as you admire yourself, the mirror shifts and opens a doorway into a warm <color=lime>inviting light that you walk into.</color>"),

            //lose!
            new Page("Leave", "(this is: Leave)\nFeeling a bit self-conscious and caught in the act, you turn to the armoire, sloughing off the jacket in the process. " +
                "Intent on walking away, you reach into the armoire for the hanger and before you know it, the darkness oozes out and pulls you into the <color=red>depths of the armoire.</color> "),         
        };
    }

    void RenderStory()
    {
        if (!string.IsNullOrEmpty(nextHeading))
        {
            for (int i = 0; i < book.Length; i++)
            {
                if (nextHeading == book[i].Heading)
                {
                    prevHeading = currHeading;
                    currHeading = nextHeading;
                    nextHeading = "";

                    screen.text = book[i].Body;
                    Debug.Log(book[i].Body);

                    return;
                }
            }

            Debug.LogWarning("Heading not found: \"" + nextHeading + "\""); 
        }
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (currHeading == "Enter Room")
            {
                nextHeading = "Sweets";
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (currHeading == "Enter Room")
            {
                nextHeading = "Wine";
            }
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (currHeading == "Enter Room")
            {
                nextHeading = "Pea Coat";
            }
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            if (currHeading == "Pea Coat")
            {
                nextHeading = "Try On";
            }
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            nextHeading = prevHeading;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            if (currHeading == "Try On")
            {
                nextHeading = "Leave";
            }
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (currHeading == "Try On")
            {
                nextHeading = "Grab";
            }
        }
    }
}
