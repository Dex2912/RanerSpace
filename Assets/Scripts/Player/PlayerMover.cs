using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpead;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _leftWidth;
    [SerializeField] private float _rightWidth;

    private float _stepSize = 2;
    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
       
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpead * Time.deltaTime);

    }

    public void TryMoveUp()
    {
        if (_targetPosition.y < _maxHeight)
            SetNextPositionVertical(-_stepSize);
    }

    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeight)
            SetNextPositionVertical(_stepSize);
    }

    public void TryMoveLeft()
    {
        if(_targetPosition.x > _leftWidth)
            SetNextPositionHorizontal(_stepSize);
    }

    public void TryMoveRight()
    {
        if (_targetPosition.x < _rightWidth)
            SetNextPositionHorizontal(- _stepSize);
    }

    private void SetNextPositionVertical( float stepSize)
    {
        _targetPosition = new Vector3(_targetPosition.x, _targetPosition.y - stepSize);
    }

    private void SetNextPositionHorizontal( float stepSize)
    {
        _targetPosition = new Vector3(_targetPosition.x - stepSize, _targetPosition.y);
    }
}
