using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLogo : MonoBehaviour
{
    [SerializeField]
    private float _speed = 500f;
    private bool _up, _down, _right, _left = false;

    //We write more but the objects are loosely coupled by subscribing to events.
    //By doing this we avoid dragging and dropping references all over the editor
    private void OnEnable()
    {
        DirectionButtons.OnDownDirection += UpdateDown;
        DirectionButtons.OnLeftDirection += UpdateLeft;
        DirectionButtons.OnRightDirection += UpdateRight;
        DirectionButtons.OnUpDirection += UpdateUp;
    }

    private void OnDisable()
    {
        DirectionButtons.OnDownDirection -= UpdateDown;
        DirectionButtons.OnLeftDirection -= UpdateLeft;
        DirectionButtons.OnRightDirection -= UpdateRight;
        DirectionButtons.OnUpDirection -= UpdateUp;
    }



    void Update()
    {
        if (_left)
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime * _speed, transform.position.y, 0f);
        }
        if (_right)
        {
            transform.position = new Vector3(transform.position.x + Time.deltaTime * _speed, transform.position.y, 0f);
        }
        if (_up)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * _speed, 0f);
        }
        if (_down)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime * _speed, 0f);
        }
    }

    private void UpdateUp(bool flag)
    {
        _up = flag;
    }

    private void UpdateDown(bool flag)
    {
        _down = flag;
    }

    private void UpdateLeft(bool flag)
    {
        _left = flag;
    }

    private void UpdateRight(bool flag)
    {
        _right = flag;
    }
}
