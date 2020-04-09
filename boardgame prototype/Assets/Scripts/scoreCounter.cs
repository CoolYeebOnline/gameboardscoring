using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scoreCounter : contactColour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (colourRed == true) //activates if the red player collides with a tile 
        {
            redScore += 1; //increases the score by 1 -- trying to figure out a method that actually does this? 
            //redScore++;
        }

        if (colourGreen == true) //activates if the green player collides with a tile
        {
            // greenScore = greenScore + 1; //neither of these work 
            //greenScore++;
        }
        Debug.Log(greenScore);

        if (colourBlue == true) //activates if the blue player collides with a tile 
        {
            //blueScore = blueScore + 1; 
            //blueScore++;
        }
        Debug.Log(blueScore);

        if (colourYellow == true) //activates if the yellow player collides with a tile 
        {
            //yellowScore = yellowScore + 1;
            //yellowScore++;
        }
        Debug.Log(yellowScore);
    }
}
