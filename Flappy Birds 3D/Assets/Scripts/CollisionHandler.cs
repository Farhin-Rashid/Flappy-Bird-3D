using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] int increasedSpeed;
    [SerializeField] AudioClip crash;

    AudioSource audioSource;

    public int score = 0;
    public int lives = 5;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        GameOver();
        Fall();
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Pillar"){
            audioSource.PlayOneShot(crash);
            lives--;
        }

        if(other.gameObject.tag == "Gap"){
            score += 5;
        }
    }

    void GameOver(){
        if(lives == 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Fall(){
        if(transform.position.y <= -8){
            if (Input.GetKey(KeyCode.Space)){
                transform.Translate(Vector3.up * increasedSpeed * Time.deltaTime);
            }
        }
    }
}
