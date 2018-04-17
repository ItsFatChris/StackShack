using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public Transform[] Spawn = new Transform[4];
    private int rand;
    private int count = 0;
    public GameObject TBun;
    public GameObject Lettuce;
    public GameObject Tomato;
    public GameObject Burger;
    public GameObject BBun;
    public GameObject Hand;
    public GameObject infoBar;
    public GameObject leftWall;
    public GameObject killBox;
    public GameObject menu;
    public GameObject showTbun;
    public GameObject showLett;
    public GameObject showTom;
    public GameObject showBurg;
    public GameObject showBbun;
    public GameObject winBox;
    public GameObject arrow;
    public int lives = 3;
    private bool hasRun = false;


   

    //right



	// Use this for initialization
	void Start () {


       
        //call spawn() every 3 seconds
        InvokeRepeating("spawn", 3.0f, 3f);

        Hand = Instantiate(Hand);
        infoBar = Instantiate(infoBar);
        leftWall = Instantiate(leftWall);
        killBox = Instantiate(killBox);

        showTbun = Instantiate(showTbun);
        
        

        killBox.GetComponent<KillBox>().setDeaths(0);
        Hand.GetComponent<HandMovement>().setCanMove(true);


    }
	
	// Update is called once per frame
	void Update () {

        CheckLives();
        	
	}

    void spawn()
    {
        rand = Random.Range(0, 3);

        switch (count)
        {
            case 0:
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Instantiate(BBun, Spawn[rand].position, Spawn[rand].rotation);
                
                Destroy(showTbun);
                showLett = Instantiate(showLett);
                
                count++;
                break;

            case 1:

                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Instantiate(Burger, Spawn[rand].position, Spawn[rand].rotation);
                
                Destroy(showLett);
                showTom = Instantiate(showTom);
                
                count++;
                break;

            case 2:
                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Instantiate(Tomato, Spawn[rand].position, Spawn[rand].rotation);
                
                Destroy(showTom);
                showBurg = Instantiate(showBurg);
                
                count++;
                break;

            case 3:
                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Instantiate(Lettuce, Spawn[rand].position, Spawn[rand].rotation);
                
                Destroy(showBurg);
                showBbun = Instantiate(showBbun);
                count++;
                break;

            case 4:
                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);

                Instantiate(TBun, Spawn[rand].position, Spawn[rand].rotation);
                count++;
                break;

            case 6:
                gameWin();
                count++;
                break;

            default:
                count++;
                break;

        }

             //Instantiate(item, Spawn[rand].position, Spawn[rand].rotation);
            
        
        

    }

    private void CheckLives()
    {
        
        if (lives < killBox.GetComponent<KillBox>().getDeaths() && hasRun == false)
        {

            gameOver();
        }

        
        

    }

    private void gameWin()
    {
        Instantiate(winBox);

    }

    private void gameOver()
    {
        hasRun = true;
        //stop control of hand
        Hand.GetComponent<HandMovement>().setCanMove(false);
        //stop spawning of burger parts
        CancelInvoke();


        Instantiate(menu);

        //pop menu
            //retry
            //quit 

    }

    public void restDeaths()
    {

        killBox.GetComponent<KillBox>().setDeaths(0);
        Hand.GetComponent<HandMovement>().setCanMove(true);
        Destroy(menu);
    }
}
