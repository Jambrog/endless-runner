using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        
         UnityEngine.SceneManagement.SceneManager.LoadScene(2);
         Debug.Log("edjfhsdfuijhs");
        
    }
}
