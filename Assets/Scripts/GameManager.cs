using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool cellsAreOpen;
    public bool playerInDinningRoom;
    public bool journalIsClosed;
    public bool lightFaded;
    public bool playerSat;
    private void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        LoadNextLevelCondition();
    }

    private void LoadNextLevelCondition()
    {
        if (lightFaded) //Trate de hacer que la camara haga un fade out subiendo la opacidad de una imagen de la UI que cubre toda la camara pero no funciona, despues del fade carga otra escena
        {
            Invoke(nameof(LoadNextLevel),3);
        }
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
}
