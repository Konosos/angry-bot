using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
    [SerializeField] ParticleSystem _particleSystem;
    private bool hasDied;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag=="Player" || collision.contacts[0].normal.y<-0.5)
        {
            if (hasDied)
            return;
            //transform.position=new Vector2(-24, -2);
            
            StartCoroutine(Wait());
            
            
        }
    }
    IEnumerator Wait()
    {
        
        _particleSystem.Play();
        yield return new WaitForSeconds(1);
        hasDied = true;
        gameObject.SetActive(false);
    }
}
