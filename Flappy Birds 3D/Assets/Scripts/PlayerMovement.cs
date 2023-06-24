using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 25f;
    [SerializeField] AudioClip audioClip;

    AudioSource audioSource;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement(){
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            
            if(!audioSource.isPlaying){
                audioSource.PlayOneShot(audioClip);
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
