using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragableObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;
    public bool isPlaced = false;
    Vector2 firstPos;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!isPlaced)
        {
            firstPos = rectTransform.anchoredPosition;
            canvasGroup.blocksRaycasts = false;
            canvasGroup.alpha = 0.8f;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isPlaced)
        {
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        if (!isPlaced)
        {
            rectTransform.anchoredPosition=firstPos;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

}
