using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenaManager : MonoBehaviour
{
	public Animator transition;
	public float transitionTime = 1f;
    // Start is called before the first frame update
    //void Start(){}

    // Update is called once per frame
    // void Update(){}
    public void Manager (string SceneData){
        StartCoroutine("LoadLevel");
		SceneManager.LoadScene(SceneData);
    }

    public void Exit (){
        Application.Quit();
    }
	
	IEnumerator LoadLevel(){
		transition.SetTrigger("Start");
		yield return new WaitForSeconds(transitionTime);
	}
}
