using UnityEngine;

using UnityEngine.EventSystems;



public class TapArea : MonoBehaviour, IPointerDownHandler

{
    public AudioSource fxfx1;
    public void OnPointerDown(PointerEventData eventData)

    {
        
        GameManager.Instance.CollectByTap(eventData.position, transform);
        fxfx1.Play();
    }

}