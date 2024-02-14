using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    private string carMake;
    private string carYear;
    private int currentSpeed;
    private int maximumSpeed;


    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = 0;
        maximumSpeed = 100;
    }





    public void Accelrate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("placeholder");
            currentSpeed++;
        }
    }

    public void Decelerate()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("placeholder");
            currentSpeed--;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
