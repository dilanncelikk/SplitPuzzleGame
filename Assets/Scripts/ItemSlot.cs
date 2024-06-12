using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private GameObject CorrectItem;
    [SerializeField] private Transform SlotsTransform;
    public bool check;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null && eventData.pointerDrag.gameObject == CorrectItem && CorrectItem!=null)
        {
           
            eventData.pointerDrag.gameObject.GetComponent<DragableObject>().isPlaced = true;
            check = true;
            transform.parent.GetComponent<SlotControl>().ControlSlot();
            eventData.pointerDrag.gameObject.transform.SetParent(SlotsTransform);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().localPosition;
        }

    }

}
