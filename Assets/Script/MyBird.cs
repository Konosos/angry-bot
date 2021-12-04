using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBird : MonoBehaviour {
    
    private Vector2 startPosition;
    private Rigidbody2D _rigibody2D;
    private bool wasFly;
    private float _x;
    private float _y;
    [SerializeField] Camera _sizeCamera;
    //public float bird_x;
    //public float bird_y;
    // Use this for initialization
    void Start ()
    {
        _rigibody2D = GetComponent<Rigidbody2D>();
        startPosition = GetComponent<Transform>().position;
        _rigibody2D.isKinematic = true;
        
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        Vector2 goPosition = GetComponent<Transform>().position;
        Vector2 direction = startPosition - goPosition;
        _rigibody2D.isKinematic = false;
        //direction.Normalize();
        _rigibody2D.velocity=direction*5;
        
        wasFly = true;
        _sizeCamera.GetComponent<Camera>().orthographicSize = 7;

    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _x = mousePosition.x;
        _y = mousePosition.y;
        if (_x>(startPosition.x-3)&&_x<(startPosition.x+3)&&_y>(startPosition.y-3)&&_y<(startPosition.y+3))
        {
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }
        if (_sizeCamera.GetComponent<Camera>().orthographicSize < 9)
        {
            _sizeCamera.GetComponent<Camera>().orthographicSize += 0.1f;
        }


    }
    

    // Update is called once per frame
    void Update ()
    {
        
        if (wasFly&& _rigibody2D.velocity.x == 0 && _rigibody2D.velocity.y == 0)
        {
            transform.position = startPosition;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
            _rigibody2D.isKinematic = true;
            wasFly = false;

        }
        //bird_x = transform.position.x;
        //bird_y = transform.position.y;
      
        
    }
}
