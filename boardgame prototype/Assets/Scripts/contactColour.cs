using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactColour : MonoBehaviour
{
    public Color Color { get; private set; }

   public float redScore = 0.0f;
   public float greenScore = 0.0f;
   public float blueScore = 0.0f;
   public float yellowScore = 0.0f;
   public float tileCount = 0.0f;
   public bool colourRed = false;
   public bool colourGreen = false;
   public bool colourBlue = false;
   public bool colourYellow = false;
    // public Color color = Color.red;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player1") //on contact with the Red player, changes the tile to red 
        {
            colourRed = true; //triggers the bool for scoreCounter to increase 
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);
            Debug.Log(redScore); //updates the score 
        }
       // if (colourRed == true)
       // {
       //     redScore = redScore + 1;
       //     Debug.Log("Red Score is: " + redScore);
       // }


        if (collision.gameObject.tag == "Player2")//on contact with the Green player, will change the tile to green 
        {
            colourGreen = true;
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.green);
           // tileCount = tileCount + 1;
            Debug.Log(greenScore);
          // if (colourGreen == true)
          // {
          //     greenScore = greenScore + 1;
          //     Debug.Log("Green Score is: " + greenScore);
          // }
        }
        

        if (collision.gameObject.tag == "Player3")//on contact with the Green player, will change the tile to blue
        {
            colourBlue = true;
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.blue);
            Debug.Log(blueScore);
        }

        if(collision.gameObject.tag == "Player4")//on contact with the Orange player, the tile will change to Orange
        {
            colourYellow = true;
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.yellow);
            Debug.Log(yellowScore);
        }
    }
}
