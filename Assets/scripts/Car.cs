using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car 
{
    private string carMake;
    private int carYear;
    private int currentSpeed;
    private int maximumSpeed;
    


    
    public string Make
    {  get
        {
          return carMake;
            
        }

        set
        {
            carMake = value;
        }
   
    }

    public int Year
    {
        get
        {
            return carYear;
        }

        set 
        { 
            if( carYear < 1886 ||carYear > 2024)
            {
                Debug.Log("Try again");
            }
            else
            {
                carYear = value;
            }
            
      
        }

 
      
    }

    public int CurrentSpeed
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
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
