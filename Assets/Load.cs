using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Serialized field to specify the name of the scene you want to load
    private string SampleScene;
    private string Default1;
    private string Default2;

    // Function to be called when the button is clicked
    public void LoadMainScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(SampleScene);
    }
    public void DefaultScene1()
    {
        // Load the specified scene
        SceneManager.LoadScene(Default1);
    }
    public void DefaultScene2()
    {
        // Load the specified scene
        SceneManager.LoadScene(Default2);
    }
}
