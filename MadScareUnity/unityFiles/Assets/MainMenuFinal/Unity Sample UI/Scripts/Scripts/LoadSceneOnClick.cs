using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOnClick : MonoBehaviour {
   
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.instance.LoadScene(1);
    }
}
