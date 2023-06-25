using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
        [SerializeField] private GameObject _loseWindow;
        public static SceneLoader Instance;


        private void Start()
        {
                Instance = this;
        }

        public void RestartScene()
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
        }

        public void Lose()
        {
                _loseWindow.SetActive(true);
                Time.timeScale = 0;

        }

        public void LoadScene(int scenaNumber)
        {
                SceneManager.LoadScene(scenaNumber);
                Time.timeScale = 1;
        }
}
