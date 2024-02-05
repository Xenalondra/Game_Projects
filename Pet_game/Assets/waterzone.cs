using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterzone : MonoBehaviour
{
    // Start is called before the first frame update
    public double waterChance = 20;
    public float checkgap = 1f;
    private float x = 0;
    public GameObject mosterGo;
    public GameObject monstergraphics;
    void Start()
    {
        x = checkgap;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(){
        checkgap -= Time.deltaTime;
        if(checkgap <= 0){
            int i = Random.Range(0,101);
            if(i <= waterChance){
                mosterGo.gameObject.GetComponent<Adventure_Behavior>().thirst += 5;
                monstergraphics.gameObject.GetComponent<Animator>().SetTrigger("gain");
                if(mosterGo.gameObject.GetComponent<Adventure_Behavior>().thirst > 20){
                    mosterGo.gameObject.GetComponent<Adventure_Behavior>().thirst = 20;
                }
            }
            checkgap = x;
        }
    }
}
