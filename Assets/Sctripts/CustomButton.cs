using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] protected UnityEvent OnClickDownEvent;
    [SerializeField] protected UnityEvent OnClickUpEvent;

    public void OnPointerDown(PointerEventData eventData)
    {
        OnClickDownEvent.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        OnClickUpEvent.Invoke();
    }
}
