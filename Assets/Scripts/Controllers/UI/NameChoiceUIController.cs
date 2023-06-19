using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class NameChoiceUIController : MonoBehaviour
{
    public TextMeshProUGUI player0Name, player1Name,gameplayPlayer0Name,gameplayPlayer1Name;
    public Button start,player1Portrait0, player1Portrait1, player0Portrait0, player0Portrait1 ;
    public TMP_InputField player0NameInput, player1NameInput;
    public Image player0Portrait, player1Portrait;

    private void Awake() {
        SetupInteractables();
    }

    private void SetupInteractables()
    {
        start.onClick.AddListener(() =>
        {
            int randomStartTurn = UnityEngine.Random.Range(0,2);
            TurnManager.instance.StartTurnGameplay(randomStartTurn);
            CardManager.instance.GenerateCards();
            gameObject.SetActive(false);
        });

        player0NameInput.onValueChanged.AddListener((nameInput) =>
        {
            PlayerManager.instance.players[0].playerName = nameInput;
            player0Name.text = nameInput;
            gameplayPlayer0Name.text = nameInput;
        });

        player1NameInput.onValueChanged.AddListener((nameInput) =>
        {
            PlayerManager.instance.players[1].playerName = nameInput;
            player1Name.text = nameInput;
           gameplayPlayer1Name.text = nameInput;
        });

        player0Portrait0.onClick.AddListener(() =>
        {
            player0Portrait.sprite = player0Portrait0.image.sprite;
        });

        player0Portrait1.onClick.AddListener(() =>
        {
            player0Portrait.sprite = player0Portrait1.image.sprite;
        });

        player1Portrait0.onClick.AddListener(() =>
        {
            player1Portrait.sprite = player1Portrait0.image.sprite;
        });
        player1Portrait1.onClick.AddListener(() =>
        {
            player1Portrait.sprite = player1Portrait1.image.sprite;
        });
    }
}
