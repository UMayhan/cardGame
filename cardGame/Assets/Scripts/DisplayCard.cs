using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{

    // public Card card; обращение к классу Card посредством card.smth
    //назначение переменных для выведения его в пресет карты
    //


    public Card card;
    //public List<Card> displayCard = new List<Card>();
    //public int displayId;

    //public int id;
    public string cardTitle;
    public string cardDescription;
    public string cardType;
    public int power;
    public int cost;

    public TextMeshProUGUI txtTitle;
    public TextMeshProUGUI txtDescription;
    public TextMeshProUGUI txtType;
    public TextMeshProUGUI txtCost;
    public Image cardImage;

    //
    // функция при старте, отвещаюшся за вывод данных на карту из обьектов типа <Card>
    //
    void Start()
    {
        power = card.power;
        cost = card.cost;
        txtTitle.text = card.cardTitle;
        txtDescription.text = card.cardDescription;
        txtType.text = card.cardType;
        txtCost.text = card.cost.ToString();
        cardImage.sprite = card.spriteImage;
        //cardImage = card.spriteImage;
        


    }


    /*private void Update()
    {
        id = displayCard[0].id;
        cardTitle = displayCard[0].cardTitle;
        cardType = displayCard[0].cardType;
        cardDescription = displayCard[0].cardDescription;
        power = displayCard[0].power;
        cost = displayCard[0].cost;

        txtTitle.text = cardTitle;
        txtDescription.text = cardDescription;
        txtType.text = cardType;
        txtCost.text = cost.ToString();

    } */

}
