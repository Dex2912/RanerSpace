using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            _mover.TryMoveUp();
        if(Input.GetKeyDown(KeyCode.S))
            _mover.TryMoveDown();
        if (Input.GetKeyDown(KeyCode.A))
            _mover.TryMoveLeft();
        if (Input.GetKeyDown(KeyCode.D))
            _mover.TryMoveRight();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 delta = Input.GetTouch(0).deltaPosition;

        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            if (delta.x > 0)
            {
                _mover.TryMoveRight();
                Debug.Log("Право");
            }
            else
            {
                _mover.TryMoveLeft();
                Debug.Log("Left");
            }
        }
        else
        {
            if (delta.y > 0)
            {
                _mover.TryMoveUp();
                Debug.Log("Up");
            }

            else
            {
                _mover.TryMoveDown();
                Debug.Log("Down");
            }
        }

    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
