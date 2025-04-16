using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public abstract class ButtonManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] protected float timeScale;
    protected Button myButton;
    protected Vector3 initialScale;
    [SerializeField] protected Vector3 toScale;

    protected void Awake()
    {
        myButton = GetComponent<Button>();
    }
    protected void Start()
    {
        initialScale = transform.localScale;
        myButton.onClick.AddListener(Interactue);
        
    }

    protected abstract void Interactue();

    public void OnPointerEnter(PointerEventData eventData)
    {
        Scale(toScale);


    }
   public void OnPointerExit(PointerEventData eventData)
    {
        Scale(initialScale);

    }

   protected void Scale(Vector3 toScale)
    {
        transform.DOScale(toScale, timeScale);
    }
}
