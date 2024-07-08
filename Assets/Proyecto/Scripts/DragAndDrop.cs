using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject objectToDrag;
    public GameObject objectDragToPos;

    public float dropDistance;

    public bool islocked;

    public RectTransform objectInitPos;

    private void Start()
    {
        objectInitPos.position = objectToDrag.transform.position;
    }

    public void DragObject()
    {
        if (!islocked)
        {
            objectToDrag.transform.position = Input.mousePosition;
        }
    }

    public void DropObject()
    {
        float Distance = Vector3.Distance(objectToDrag.transform.position, objectDragToPos.transform.position);
        if(Distance < dropDistance)
        {
            islocked = true;
            objectToDrag.transform.position = objectDragToPos.transform.position;
        }
        else
        {
            objectToDrag.transform.position = objectInitPos.position;
        }
    }

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
}
