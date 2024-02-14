using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car 
{
    private string carMake;
    private string carYear;
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

    public string Year
    {
        get
        {
            return carYear;
        }

        set 
        {
            carYear = value;
            
      
        }

 
      
    }

    public int CurrentSpeed
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
    }

    public void Accelrate()
    {
        
            currentSpeed++;
        
    }

    public void Decelerate()
    {
        
            currentSpeed--;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
