using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemuMover : MonoBehaviour
{
    [SerializeField] private float _spead;


    private void Update()
    {
        //_spead = Random.Range(3, 7);
        transform.Translate(Vector3.down * _spead * Time.deltaTime);
    }
}
