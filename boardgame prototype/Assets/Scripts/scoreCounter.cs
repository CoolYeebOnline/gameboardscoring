using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scoreCounter : contactColour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (colourRed == true)
        {
            redScore = redScore + 1;
            Debug.Log("Red Score is: " + redScore);
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
