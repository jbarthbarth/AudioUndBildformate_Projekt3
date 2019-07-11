using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem part;
    
    // Start is called before the first frame update

    void Awake()
    {
     
       // part = gameObject.GetComponent<ParticleSystem>();
        var main = part.main;
        main.loop = true;
      
       
    }

    void Start()
    {
        part.Play();

        //part.enableEmission = true;
    }

    

    // Update is called once per frame
    void Update()
    {

        
    }
}
