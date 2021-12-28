using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oncollision : MonoBehaviour
{
    

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.CompareTag("enemy"))

    {   
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    else if(collision.gameObject.CompareTag("NextLevel"))
{

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}    
}




}
