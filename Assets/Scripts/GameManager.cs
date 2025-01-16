using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCommands();
    }
    public void GetCommands()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            Debug.Log("A");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("B");
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("X");
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            Debug.Log("Y");
        }
    }
    private void __GetEnemySequence(){
        
    }
}
