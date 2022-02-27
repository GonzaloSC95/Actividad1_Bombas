using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
    public void Game() {
        SceneManager.LoadScene("Bomb");
    }

    public void Quit() {
        Application.Quit();
    }
}
