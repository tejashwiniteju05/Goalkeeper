using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    private int Goals=0;
    [SerializeField] 
    private TextMeshProUGUI scoreText;  
                

    private void Start()
    {
        scoreText.text = "Score: 0"; 
    }

    
   private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            Goals++;
            scoreText.text="Score: "+Goals;
            Destroy(other.gameObject);
            

        }
    }
   
}

