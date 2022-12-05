using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestTouch : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    [SerializeField] private GameObject Object;


    private void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta;

        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            if (delta.x > 0)
                Debug.Log("Right");
            else
                Debug.Log("Left");

        }
        else
        {
            if ((delta.y > 0))
                Debug.Log("Up");
            else
                Debug.Log("Down");

        }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
