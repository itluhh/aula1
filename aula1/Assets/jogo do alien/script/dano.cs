using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dano : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);          
        }
    }
}