using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    private string carMake;
    private string carYear;
    public int currentSpeed;
    private int maximumSpeed;


    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = 0;
        maximumSpeed = 100;
    }





    void Accelrate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("placeholder");
        }
    }

    void Decelerate()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("placeholder");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
