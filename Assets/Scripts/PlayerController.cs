using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalMove;
    private float _verticalMove;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMove = Input.GetAxis("Horizontal");
        _verticalMove = Input.GetAxis("Vertical");

        transform.Translate(_horizontalMove * 5 * Time.deltaTime, 0, _verticalMove * 5 * Time.deltaTime);
    }
}
