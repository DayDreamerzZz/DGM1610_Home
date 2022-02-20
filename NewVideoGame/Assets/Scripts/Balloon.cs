using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;  // Score give for popped balloon.
    
    public int clicktopop = 3;  //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Scale increase eaach time the balloon is clicked on

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Reduce clicks by one
        clicktopop -= 1;
        //Increase
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clicktopop == 0)
        {
            Destroy(gameObject);
        }
    }
}
