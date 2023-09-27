using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillWater : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Movement>().bucket.SetActive(true);
            other.gameObject.GetComponent<Movement>().hasWater=true;
        }
    }

}
