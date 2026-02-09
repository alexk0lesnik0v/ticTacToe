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
        bool isZero = m_playerController.CrossOrZero();
        
        if (isZero)
        {
            SetSprite(m_zero, true);
        }
        else
        {
            SetSprite(m_cross, false);
        }
    }

    private void SetSprite(Sprite _sprite, bool isZero)
    {
        m_image.GetComponent<Image>().sprite = _sprite;
        sprite = _sprite;
        m_audioSource.PlayOneShot(m_audioClip);
            
        m_playerController.CheckWin(isZero);
    }
}
