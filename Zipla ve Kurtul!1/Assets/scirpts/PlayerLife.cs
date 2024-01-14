using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    SoundManager soundManagerScript;
    private Rigidbody2D rb;
   

    private void Start()
    {
	soundManagerScript = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
        rb = GetComponent<Rigidbody2D>();
	
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
	    soundManagerScript.Died();
	    Die();
            StartCoroutine(DieAndRestart());
        }

    }

    private IEnumerator DieAndRestart()
    {
        yield return new WaitForSeconds(0.75f); // Bekleme süresi (örneğin 1 saniye)

        
        RestartLevel();
    }

    private void Die()
    {
	
	rb.bodyType = RigidbodyType2D.Static;
        
        
    }

    private void RestartLevel()
    {
	
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}