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
    
    void Start(){
        handlePointChange(0);
    }

    public void handlePointChange(int index){
        target = points[index];
    }

    public void changeResolution(bool right){
        if(right){
            if(resolutionIndex == resolutionOptions.Length -1){
                resolutionIndex = 0;
            }else{
                resolutionIndex +=1;
            }

        }else{
            if(resolutionIndex == 0){
                resolutionIndex = resolutionOptions.Length -1;
            }else{
                resolutionIndex -= 1;
            }
        }
        resolutionText.text = resolutionOptions[resolutionIndex];
    }

    public void changeDisplay(bool right){
        if(right){
            if(displayIndex == displayOptions.Length -1){
                displayIndex = 0;
            }else{
                displayIndex +=1;
            }

        }else{
            if(displayIndex == 0){
                displayIndex = displayOptions.Length -1;
            }else{
                displayIndex -= 1;
            }
        }
        displayText.text = displayOptions[displayIndex];
    }
    public void changeQuality(bool right){
        if(right){
            if(qualityIndex == qualityOptions.Length -1){
                qualityIndex = 0;
            }else{
                qualityIndex +=1;
            }

        }else{
            if(qualityIndex == 0){
                qualityIndex = qualityOptions.Length -1;
            }else{
                qualityIndex -= 1;
            }
        }
        qualityText.text = qualityOptions[qualityIndex];
    }

    public void changeVSync(bool right){
        if(right){
            if(vsyncIndex == vsyncOptions.Length -1){
                vsyncIndex = 0;
            }else{
                vsyncIndex +=1;
            }

        }else{
            if(vsyncIndex == 0){
                vsyncIndex = vsyncOptions.Length -1;
            }else{
                vsyncIndex -= 1;
            }
        }
        vsyncOptionsText.text = vsyncOptions[vsyncIndex];
    }

    public void changeArenas(){
        if(arenasIndex == arenasOptions.Length -1){
            arenasIndex = 0;
        }else{
            arenasIndex +=1;
        }
        arenasText.text = arenasOptions[arenasIndex];
    }

    public void changeScene(string sceneName){
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

}
