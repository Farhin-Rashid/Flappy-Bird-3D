using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] TMP_Text scoreText;
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + player.GetComponent<CollisionHandler>().score;
    }
}
