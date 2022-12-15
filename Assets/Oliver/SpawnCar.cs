using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject[] cars;
   // public GameObject startposition;
    // Start is called before the first frame update
    void Start()
    {
        GameObject SelectCar=cars[CarSelection.currentCar];
        SelectCar.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// Debug.Log(SelectCar.getActive());