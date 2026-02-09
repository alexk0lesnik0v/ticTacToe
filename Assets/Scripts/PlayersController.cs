using System.Collections.Generic;
using UnityEngine;

public class PlayersController : MonoBehaviour
{
    [SerializeField] private List<GameObject> m_slots;
    
    private int m_index = 0;

    private void Start()
    {
        m_index = 0;
    }

    public int CrossOrZero()
    {
        m_index++;
        return m_index;
    }

    private void Update()
    {
        
    }
}
