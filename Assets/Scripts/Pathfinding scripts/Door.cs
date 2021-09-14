using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;
    private float countDown = 5;//set timer seconds
    private bool countingDown = false;
    
   
    void Start()
    {
        countingDown = true;// start countdown
    }

    
    void Update()
    {
        if(countingDown)
        {
            if(countDown > 0)
            {
                countDown -= Time.deltaTime;//minus coundown by real time
            }
            else
            {
                if(door.position.y == 0)//if door is 'open' when timer runs out 'close' it
                {
                    transform.position = new Vector3(0, -3, 0);
                    countDown = 5;//reset timer
                }
                else if(door.position.y == -3)//if door is 'closed' when timer runs out 'open' it
                {
                    transform.position = new Vector3(0, 0, 0);
                    countDown = 5;//reset timer
                }
                
            }
        }
    }
}
