using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oncollision : MonoBehaviour
{
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource finishLevel;
    

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.CompareTag("enemy"))

    {   
       Die();
       Invoke("RestartLevel", 0.4f);


    }

    else if(collision.gameObject.CompareTag("NextLevel"))
{

    finishLevel.Play();
    Invoke("CompleteLevel", 0.7f);
  
  
}    
}

private void CompleteLevel()
{
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

private void RestartLevel()
{

    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

}

private void Die()

{
 deathSoundEffect.Play();
}



}
