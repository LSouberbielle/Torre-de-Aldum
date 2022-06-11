using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  [SerializeField] private GameObject creditsMenu;
  public void PlayGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void ExitGame()
  {
    Debug.Log("Quit!");
    Application.Quit();
  }

  public void Credits()
  {
    creditsMenu.SetActive(true);
  }
}
