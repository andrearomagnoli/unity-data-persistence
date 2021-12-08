using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    #region Parameters

    [SerializeField] private TMP_InputField nickname;

    #endregion

    #region Methods

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void LoadGame()
    {
        GameStatus.Instance.Nickname = nickname.text;
        SceneManager.LoadScene("main");
    }

    public void Quit()
    {
        Application.Quit();
    }

    #endregion
}
