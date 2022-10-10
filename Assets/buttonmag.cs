using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonmag : MonoBehaviour
{
    public void retry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void exit()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
