using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = GetComponent<PlayerController>();
       
        if (controller != null && controller.health< controller.health)
        {           
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
