using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    public GameObject death;	// now you have to drag and drop your canvas in the editor in the script component
    public GameObject alive;
	public bool deathActive;
    
    void Start ()
	{
        deathActive = false;
        Time.timeScale = 1;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.GetComponent<Movement>().hasWater)
            {
                //Fire dies
                other.gameObject.GetComponent<Movement>().bucket.SetActive(false);
                other.gameObject.GetComponent<Movement>().hasWater=false;
                alive.SetActive(false);
            }

            else
            {
                //Player dies
                deathActive = true;
                death.SetActive(deathActive);
                Time.timeScale = 0;
            }
        }
    }
}
