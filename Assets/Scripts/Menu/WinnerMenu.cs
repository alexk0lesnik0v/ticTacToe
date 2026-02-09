using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu
{
    public class WinnerMenu  : MonoBehaviour
    {
        [SerializeField] private Button m_restartButton;
        [SerializeField] private Button m_mainmenuButton;
        [SerializeField] private Button m_exitButton;
        
        [SerializeField] private TMP_Text m_winnerText;
        
        private void OnEnable()
        {
            m_restartButton.onClick.AddListener(OnRestart);
            m_mainmenuButton.onClick.AddListener(OnMainMenu);
            m_exitButton.onClick.AddListener(OnExit);
        }
        private void OnDisable()
        {
            m_restartButton.onClick.RemoveListener(OnRestart);
            m_mainmenuButton.onClick.RemoveListener(OnMainMenu);
            m_exitButton?.onClick.RemoveListener(OnExit);
        }
        private void OnRestart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        private void OnMainMenu()
        {
            SceneManager.LoadScene(0);
        }
        
        public void OnExit()
        {
            Application.Quit();
        }

        public void SetWinnerText(string winner)
        {
            m_winnerText.text = winner;
        }
    }
}