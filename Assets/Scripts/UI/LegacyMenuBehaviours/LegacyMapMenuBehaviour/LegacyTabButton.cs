using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class LegacyTabButton : MonoBehaviour /*,IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler*/
{
    /*public LegacyTabGroup tabGroup;
    public Image background;
    public GameObject map;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
        map.SetActive(true);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        tabGroup.Heck(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
