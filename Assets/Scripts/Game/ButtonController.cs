using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public  class ButtonController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float timeScale;
    private Vector3 initialScale;
    [SerializeField] private Vector3 toScale;

    void Start()
    {
        initialScale = transform.localScale;    
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Scale(toScale);


    }
   public void OnPointerExit(PointerEventData eventData)
    {
        Scale(initialScale);

    }

   void Scale(Vector3 toScale)
    {
        transform.DOScale(toScale, timeScale);
    }
}
