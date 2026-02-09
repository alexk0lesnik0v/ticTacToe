using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private PlayersController m_playerController;
    [SerializeField] private GameObject m_image;
    
    [SerializeField] private Sprite m_cross;
    [SerializeField] private Sprite m_zero;
    
    [SerializeField] AudioSource m_audioSource;
    [SerializeField] private AudioClip m_audioClip;

    public Sprite sprite = null;

    private void Start()
    {
        m_playerController = FindObjectOfType<PlayersController>();
        m_image = transform.GetChild(0).gameObject;
        m_audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        int index = m_playerController.CrossOrZero();
        
        if (index % 2 == 0)
        {
            m_image.GetComponent<Image>().sprite = m_zero;
            sprite = m_zero;
            m_audioSource.PlayOneShot(m_audioClip);
            
            m_playerController.CheckWin();
        }
        else
        {
            m_image.GetComponent<Image>().sprite = m_cross;
            sprite = m_cross;
            m_audioSource.PlayOneShot(m_audioClip);
            
            m_playerController.CheckWin();
        }
    }
}
