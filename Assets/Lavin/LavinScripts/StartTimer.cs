using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartTimer : MonoBehaviour
{
    public GameObject FrontCamera;
    public GameObject BackCamera;
    public GameObject RedLights;
    public GameObject YellowLights;
    public GameObject GreenLights;
    public GameObject Car;


    public TMP_Text starterCountdown;

    public static float starterTimer = 3.0f;

    // Start is called before the first frame update
    // void Start()
    // {
    //     if (FrontCamera.activeInHierarchy == true)
    //     {
    //         Debug.Log("Hej");
    //     }
    //     Car.GetComponent<CarControl2>().enabled = false;

    // }

    // Update is called once per frame
    void Update()
    {
        if (starterTimer > -1.0f)
        {
            if (starterTimer <= 3.0f)
            {
                starterTimer -= Time.deltaTime;
            }
            if (starterTimer >= 2.0f)
            {
                YellowLights.SetActive(false);
                GreenLights.SetActive(false);
                starterCountdown.text = "3";
            }
            if (starterTimer <= 2.0f)
            {
                RedLights.SetActive(false);
                YellowLights.SetActive(true);
                starterCountdown.text = "2";
            }
            if (starterTimer <= 1.0f)
            {
                starterCountdown.text = "1";
            }
            if (starterTimer <= 0.0f)
            {
                GreenLights.SetActive(true);
                YellowLights.SetActive(false);
                starterCountdown.text = "GO!";
                Car.GetComponent<CarControl2>().enabled = true;
            }
            if (starterTimer <= -1.0f)
            {
                starterCountdown.text = "";
            }
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            FrontCamera.SetActive(!FrontCamera.activeInHierarchy);
            BackCamera.SetActive(!BackCamera.activeInHierarchy);
        }
    }
}
