using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;
    private float countDown = 5;
    private bool countingDown = false;
    
    // Start is called before the first frame update
    void Start()
    {
        countingDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(countingDown)
        {
            if(countDown > 0)
            {
                countDown -= Time.deltaTime;
            }
            else
            {
                if(door.position.y == 0)
                {
                    transform.position = new Vector3(0, -3, 0);
                    countDown = 5;
                }
                else if(door.position.y == -3)
                {
                    transform.position = new Vector3(0, 0, 0);
                    countDown = 5;
                }
                
            }
        }
    }
}
