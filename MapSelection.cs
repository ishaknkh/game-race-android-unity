using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelection : MonoBehaviour
{
    public void day()
    {
        SceneManager.LoadScene("scene_day");
    }

    public void night()
    {
        SceneManager.LoadScene("scene_night");
    }

    public void overcast()
    {
        SceneManager.LoadScene("scene_overcast");
    }
}