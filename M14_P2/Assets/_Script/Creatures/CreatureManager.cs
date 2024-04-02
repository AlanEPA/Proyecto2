using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureManager : MonoBehaviour
{
    [Header("Atributes")]

    [SerializeField] public string creatureName;
    [SerializeField] private float health;
    [SerializeField] private int level;
    [SerializeField] private int cooldawn;
    [SerializeField] private float classType;
    [SerializeField] private int creaturePrice;

    [Header("Animations")]
    [SerializeField] private Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
