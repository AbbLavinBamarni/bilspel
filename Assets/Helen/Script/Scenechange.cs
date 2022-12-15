using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;



public class Scenechange : MonoBehaviour

{

    //Changes scene

    public void MoveToScene(int SceneID)
    {

        SceneManager.LoadScene(SceneID);

    }





}
