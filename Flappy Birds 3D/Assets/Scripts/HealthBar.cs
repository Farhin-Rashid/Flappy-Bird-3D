using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Slider slider;

    // Update is called once per frame
    void Update()
    {
       slider.value = player.GetComponent<CollisionHandler>().lives;
    }
}
