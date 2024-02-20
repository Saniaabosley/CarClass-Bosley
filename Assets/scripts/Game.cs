using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//////////////////////////////////////////////
//Assignment/Lab/Project: CarClass
//Name: Saniaa Bosley
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: -02/19/2024
/////////////////////////////////////////////

public class Game : MonoBehaviour
{

    public InputField carYearInput;
    public InputField carMakeInput;
    public TextMeshProUGUI carMakeText;
    public TextMeshProUGUI carYearText;
    public TextMeshProUGUI speedText;
    private int minimumSpeed = 0;

    Car newCar = new Car();

    // Start is called before the first frame update
    public void Start()
    {
        newCar.CurrentSpeed = 0;
        //newCar.Accelrate();
       // Debug.Log(newCar.Make);

        newCar.Make = carMakeInput.text;
         newCar.Year = carYearInput.text;
        carMakeText.text = "Car Make: " + newCar.Make;
        carYearText.text = "Car Year: " + newCar.Year;
        speedText.text = "Current Speed: " + newCar.CurrentSpeed + "mph";

       


    }


    public void carAccleration()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            newCar.Accelrate();
            Debug.Log(newCar.CurrentSpeed);
            speedText.text = "Current Speed: " + newCar.CurrentSpeed + "mph";

           if (newCar.CurrentSpeed  >= 99)
            {
               newCar.CurrentSpeed = newCar.Max;
            }
             
            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            newCar.Decelerate();
            speedText.text = "Current Speed: " + newCar.CurrentSpeed + "mph";
             if (newCar.CurrentSpeed  <= 0)
            {
               newCar.CurrentSpeed = minimumSpeed;
            }

        
        }
    }

    private void Update()
    {
        carAccleration();
    }


}
