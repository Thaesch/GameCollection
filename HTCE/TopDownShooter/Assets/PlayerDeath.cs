using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

    private bool playerDied;

    public bool Dead { get => playerDied; }

    private void OnDeath()
    {
        gameObject.SetActive(false);
        playerDied = true;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            OnDeath();
        }
    }


}
