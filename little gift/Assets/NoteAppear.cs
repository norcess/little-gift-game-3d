using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteAppear : MonoBehaviour
{
    public Image _noteImage;
    public AudioClip lettersound;

    void OnTriggerEnter(Collider other) 
    {
        {
            AudioSource.PlayClipAtPoint(lettersound, transform.position);
            if (other.CompareTag("Player"))
            {
                _noteImage.enabled = true;
            }
        }
    
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            _noteImage.enabled = false;
        }
    }
    
      
}
