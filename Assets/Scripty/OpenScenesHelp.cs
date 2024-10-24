using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenScenesHelp : MonoBehaviour
{
    public string sceneOpen;

    public void OpenScene()
    {
        SceneManager.LoadScene(sceneOpen);
    }

}
