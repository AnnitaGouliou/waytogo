using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{

    [SerializeField] private AudioSource collectionSoundEffect;
    private Object thisObject;

    private void Awake()
    {
        thisObject = GetComponent<ObjectsCollectible>();
    }

private void OnTriggerEnter2D(Collider2D collision)
{
    if(collision.CompareTag("PlayerCollider"))
        {
                collectionSoundEffect.Play();
                Destroy(collision.gameObject);

              
}

                
     }
 


}


