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
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);
            colourRed = true;
            Debug.Log("This is Red!");
        }
       // if (colourRed == true)
       // {
       //     redScore = redScore + 1;
       //     Debug.Log("Red Score is: " + redScore);
       // }


        if (collision.gameObject.tag == "Player2")//on contact with the Green player, will change the tile to green 
        {
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.green);
           // tileCount = tileCount + 1;
            colourGreen = true;
            Debug.Log("This is Green!");
          // if (colourGreen == true)
          // {
          //     greenScore = greenScore + 1;
          //     Debug.Log("Green Score is: " + greenScore);
          // }
        }
        

        if (collision.gameObject.tag == "Player3")//on contact with the Green player, will change the tile to blue
        {
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.blue);
            colourBlue = true;
            Debug.Log("This is Blue!");
        }

        if(collision.gameObject.tag == "Player4")//on contact with the Orange player, the tile will change to Orange
        {
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.yellow);
            colourYellow = true;
            Debug.Log("This is Orange!");
        }

        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
