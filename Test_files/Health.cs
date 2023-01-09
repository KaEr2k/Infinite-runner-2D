using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float health = 1f;
    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Hit! Current Health: " + health);
        if (health < 0.01)
        {
            SceneManager.LoadScene(0);
        }
    }
}
