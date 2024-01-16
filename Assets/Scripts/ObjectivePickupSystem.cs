using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ObjectivePickupSystem : MonoBehaviour
{
    [Header("Objective Pickup System")]
    [Space]
    [Header("Necessary")]
    [Space]
    [SerializeField] string enemyTag;
    [SerializeField] List<PickupObjective> pickupObjectives = new List<PickupObjective>();
    [SerializeField] string objectiveTag;
    
    [SerializeField] Transform cam;
    [SerializeField, Range(0,10)] int pickupRange; 
    [SerializeField] AudioSource pickupSound;
    [SerializeField] TextMeshProUGUI objectivesText;
    [HideInInspector] GameObject lastFoundObjective;


    void Start(){
        for(int i = 0; i < pickupObjectives.Count; i++){
            pickupObjectives[i].gameObject.GetComponent<Outline>().enabled = false;
            pickupObjectives[i].gameObject.GetComponentInChildren<Canvas>().enabled = false;
            objectivesText.text = $"{7 - pickupObjectives.Count}/7 OBJECTIVES";
        }
    }

    void Update(){
        RaycastHit hit;
        GameObject objective;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, pickupRange)){
            if(hit.transform.gameObject.tag == objectiveTag){
                if(lastFoundObjective != hit.transform.gameObject){
                    lastFoundObjective = hit.transform.gameObject;
                    objective = hit.transform.gameObject;
                }
                objective = hit.transform.gameObject;
                objective.GetComponent<Outline>().enabled = true;
                objective.GetComponentInChildren<Canvas>().enabled = true;
                if(Input.GetKeyDown(KeyCode.E)){
                    PickupObjective pickup = objective.GetComponent<PickupObjective>();
                    pickupSound.Play();
                    PickupObjective target = pickupObjectives.Find(item => item.id == pickup.id);
                    
                    pickupObjectives.Remove(target);
                    objectivesText.text = $"{7 - pickupObjectives.Count}/7 OBJECTIVES";
                    target.gameObject.SetActive(false);
                }
            }else{
                if(lastFoundObjective != null){
                    lastFoundObjective.GetComponent<Outline>().enabled = false;
                    lastFoundObjective.GetComponentInChildren<Canvas>().enabled = false;
                }
            }
        }
        
        if(pickupObjectives.Count == 0){
            SceneManager.LoadScene("End", LoadSceneMode.Single);
        }
    }

    public void OnCollisionEnter(Collision collider){
        if(collider.gameObject.tag == enemyTag){
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            print("TOUCHED");
        }
    }
}
