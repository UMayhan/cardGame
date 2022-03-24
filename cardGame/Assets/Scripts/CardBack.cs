using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardBack : MonoBehaviour
{

    public GameObject cardBack;
    //public Card card;
    //public Image cardBackImage;


    // Start is called before the first frame update
    /*void Start()
    {
        cardBackImage.sprite = card.spriteBackImage;
    }*/

    // Update is called once per frame
    void Update()
    {

        
        if (DisplayCard.staticCardBack == true)
        {
            cardBack.SetActive(true);
        }
        else
        {
            cardBack.SetActive(false);
        }
    }
}
