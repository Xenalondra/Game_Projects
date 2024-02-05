using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure_Behavior : MonoBehaviour
{
   // Start is called before the first frame update
    public float hunger = 20;
    public float thirst = 20;
    public Slider foodS;
    public Slider waterS;
    public float resourcedeclinegap = 3;
    private float x = 0; 
    void Start()
    {
         x = resourcedeclinegap;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.A)){
           this.transform.Translate(Vector3.left * 2 * Time.deltaTime);
       } 
       if(Input.GetKey(KeyCode.S)){
           this.transform.Translate(Vector3.down * 2 * Time.deltaTime);
       } 
       if(Input.GetKey(KeyCode.W)){
           this.transform.Translate(Vector3.up * 2 * Time.deltaTime);
       } 
       if(Input.GetKey(KeyCode.D)){
           this.transform.Translate(Vector3.right * 2 * Time.deltaTime);
       } 
       resourcedeclinegap -= Time.deltaTime;
       if(resourcedeclinegap <= 0){
            hunger -= 2;
            thirst -=2;
            resourcedeclinegap = x;
        }

        foodS.value = hunger;
        waterS.value = thirst;
}
        public void SaveThisGame(){
            PlayerPrefs.SetFloat("hunger",hunger);
            PlayerPrefs.SetFloat("thirst",thirst);
            PlayerPrefs.SetFloat("x",this.transform.position.x);
            PlayerPrefs.SetFloat("y",this.transform.position.y);
        }
        public void LoadThisGame(){
            hunger = PlayerPrefs.GetFloat("hunger");
            thirst = PlayerPrefs.GetFloat("thirst");
            this.transform.position = new Vector3(PlayerPrefs.GetFloat("x"),PlayerPrefs.GetFloat("y"),-5);
        }

}