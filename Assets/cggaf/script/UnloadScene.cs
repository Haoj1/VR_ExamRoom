using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UnloadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string unloadScene;
    void Start()
    {
        UnloadOtherScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UnloadOtherScene() {
        Scene otherScene = SceneManager.GetSceneByName(unloadScene);
        if (otherScene.isLoaded) {
            SceneManager.UnloadSceneAsync(otherScene);
        }
    }
}
