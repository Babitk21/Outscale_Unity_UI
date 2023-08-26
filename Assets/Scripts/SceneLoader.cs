using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Button NextScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update() {
    //    NextScene.onClick.AddListener(LoadingNextScene);
    //}
    public void LoadingFirstScene() {
        SceneManager.LoadScene(1);
    }    
    public void LoadingSecondScene() {
        SceneManager.LoadScene(2);
    }
    public void LoadingStartingScene() {
        SceneManager.LoadScene(0);
    }
}
