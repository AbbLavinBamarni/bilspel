using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TillStart : MonoBehaviour
{
    [SerializeField] private GameObject StartPosition;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.R)) {
        //     transform.position = StartPosition.transform.position;
        //     transform.rotation = StartPosition.transform.rotation;
        //     // GetComponent<CarController>().StopCar();
        // }
    }

    void OnTriggerEnter(Collider col){
       Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Water"){
        Destroy(gameObject);
        }

    }
}
