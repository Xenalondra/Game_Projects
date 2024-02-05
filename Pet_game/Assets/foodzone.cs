using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodzone : MonoBehaviour
{
    // Start is called before the first frame update
     public double foodChance = 10;
    public float checkgap = 2f;
    private float x = 0;
    public GameObject mosterGo;
    public GameObject monstergraphics;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(){
        checkgap -= Time.deltaTime;
        if(checkgap <= 0){
            int i = Random.Range(0,101);
            if(i <= foodChance){
                mosterGo.gameObject.GetComponent<Adventure_Behavior>().hunger += 5;
                monstergraphics.gameObject.GetComponent<Animator>().SetTrigger("gain");
                if(mosterGo.gameObject.GetComponent<Adventure_Behavior>().hunger > 20){
                    mosterGo.gameObject.GetComponent<Adventure_Behavior>().hunger = 20;
                }
            }
            checkgap = x;
        }
    }
}
