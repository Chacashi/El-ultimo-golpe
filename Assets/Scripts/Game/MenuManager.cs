using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    [SerializeField] TMP_Text textTitle;
    [SerializeField] float durationFadeText;

    private Tween fadeTween;



    private void Start()
    {
      
            

        Fade(1, durationFadeText, textTitle);

    }


 
    public void Fade(float endValue, float duration, TMP_Text element)
    {

        element.DOFade(endValue, duration);
    }
    
    



}

