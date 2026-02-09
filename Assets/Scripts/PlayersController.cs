using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayersController : MonoBehaviour
{
    [SerializeField] private List<Slot> m_slots;
    [SerializeField] private TMP_Text m_playersTurnText;
    
    private int m_index = 0;

    private void Start()
    {
        m_index = 0;
    }
   
    public bool CrossOrZero()
    {
        m_index++;

        if (m_index % 2 == 0)
        {
            m_playersTurnText.text = "PLAYER 1 TURN";
            return true;
        }
        else
        {
            m_playersTurnText.text = "PLAYER 2 TURN";
            return false;
        }
    }
    
    public void CheckWin(bool isZero)
    {
        if (m_slots[4].sprite !=null)
        {
            if (m_slots[4].sprite == m_slots[0].sprite && m_slots[4].sprite == m_slots[8].sprite
                || m_slots[4].sprite == m_slots[1].sprite && m_slots[4].sprite == m_slots[7].sprite
                || m_slots[4].sprite == m_slots[2].sprite && m_slots[4].sprite == m_slots[6].sprite
                || m_slots[4].sprite == m_slots[3].sprite && m_slots[4].sprite == m_slots[5].sprite)
            {
               CheckWinner(isZero);
               return;
            }
        }
        
        if (m_slots[0].sprite !=null)
        {
            if (m_slots[0].sprite == m_slots[1].sprite && m_slots[0].sprite == m_slots[2].sprite
                || m_slots[0].sprite == m_slots[3].sprite && m_slots[0].sprite == m_slots[6].sprite)
            {
                CheckWinner(isZero);
                return;
            }
        }
        
        if (m_slots[8].sprite !=null)
        {
            if (m_slots[8].sprite == m_slots[2].sprite && m_slots[8].sprite == m_slots[5].sprite
                || m_slots[8].sprite == m_slots[6].sprite && m_slots[8].sprite == m_slots[7].sprite)
            {
                CheckWinner(isZero);
                return;
            }
        }

        if (m_index >= 9)
        {
            Debug.Log("DRAW");
            m_playersTurnText.text = "";
        }
    }

    private void CheckWinner(bool isZero)
    {
        if (isZero)
        {
            Debug.Log("Player 2 Win!!!");
            m_playersTurnText.text = "";
        }
        else
        {
            Debug.Log("Player 1 Win!!!");
            m_playersTurnText.text = "";
        }
    }
}
