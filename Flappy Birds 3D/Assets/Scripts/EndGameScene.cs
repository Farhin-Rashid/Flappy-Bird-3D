using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class EndGameScene : MonoBehaviour
{
    [SerializeField] AudioClip restart;

    AudioSource audioSource;
    
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    public void Retry(){
        audioSource.PlayOneShot(restart);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
