using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePickupSystem : MonoBehaviour
{
    [Header("Objective Pickup System")]
    [Space]
    [Header("Necessary")]
    [Space]
    [SerializeField] List<PickupObjective> pickupObjectives = new List<PickupObjective>();
    [SerializeField] string objectiveTag;

    void Start(){
        for(int i = 0; i < pickupObjectives.Count; i++){
            pickupObjectives[i].gameObject.AddComponent<Outline>().enabled = false;
            pickupObjectives[i].gameObject.GetComponent<Outline>().OutlineWidth = 10;
            pickupObjectives[i].gameObject.GetComponent<Outline>().enabled = true;
        }
    }

    public void OnCollisionEnter(Collision collider){
        if(collider.gameObject.tag == objectiveTag){
            PickupObjective objective = collider.gameObject.GetComponent<PickupObjective>();

            PickupObjective target = pickupObjectives.Find(item => item.id == objective.id);
            
            pickupObjectives.Remove(target);

            target.gameObject.SetActive(false);
        }
    }
}
