using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [Header("Menu Handler")]
    [Space]
    [Header("Neccesary")]
    [SerializeField] Transform[] points;
    [HideInInspector] int currentIndex;
    [HideInInspector] Transform target;
    [Space]
    [Header("Customizable")]
    [SerializeField] float positionSmothness;
    [SerializeField] float rotationSmothness;
    [Space]
    [Header("Resolution")]
    [SerializeField] string[] resolutionOptions;
    [SerializeField] TMP_Text resolutionText;
    [HideInInspector] int resolutionIndex;
    [Space]
    [Header("Display")]
    [SerializeField] string[] displayOptions;
    [SerializeField] TMP_Text displayText;
    [HideInInspector] int displayIndex;
    [Space]
    [Header("Quality")]
    [SerializeField] string[] qualityOptions;
    [SerializeField] TMP_Text qualityText;
    [HideInInspector] int qualityIndex;
    [Space]
    [Header("VSync")]
    [SerializeField] string[] vsyncOptions;
    [SerializeField] TMP_Text vsyncOptionsText;
    [HideInInspector] int vsyncIndex;

    [Space]
    [Header("Game Modes")]
    [Space]
    [Header("Arenas")]
    [SerializeField] string[] arenasOptions;
    [SerializeField] TMP_Text arenasText;
    [HideInInspector] int arenasIndex;
    public void changeScene(string sceneName){
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

}
