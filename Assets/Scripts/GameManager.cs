using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCommands();
        // __GetEnemySequence();
    }
    public void GetCommands()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            Debug.Log("A");
            __GetEnemySequence('A');
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("B");
            __GetEnemySequence('B');
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("X");
            __GetEnemySequence('X');
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            Debug.Log("Y");
            __GetEnemySequence('Y');
        }
    }
    private void __GetEnemySequence(char buttonValue){
        foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy")){
            if(enemy.GetComponent<Enemy>().enemySequence[0] == buttonValue){
                Debug.Log(enemy.name);
                enemy.GetComponent<Enemy>().enemySequence.ToList().RemoveAt(0);
            }
        }
    }
}
