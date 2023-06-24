using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] AudioClip playSound;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void Play(){
        audioSource.PlayOneShot(playSound);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
