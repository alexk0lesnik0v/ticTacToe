using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private Button m_playButton;
        [SerializeField] private Button m_exitButton;

        private void OnEnable()
        {
            m_playButton.onClick.AddListener(OnPlay);
            m_exitButton.onClick.AddListener(OnExit);
        }
        private void OnDisable()
        {
            m_playButton?.onClick.RemoveListener(OnPlay);
            m_exitButton?.onClick.RemoveListener(OnExit);
        }
        public void OnPlay()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void OnExit()
        {
            Application.Quit();
        }
    }
}