using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLevel2 : MonoBehaviour {



    public Transform[] Spawn = new Transform[4];
    public Transform StartSpawn;
    private int rand;
    private int count = 0;


    public GameObject TBun;
    public GameObject Lettuce;
    public GameObject Tomato;
    public GameObject Burger;
    public GameObject BBun;
    public GameObject Hand;
    public GameObject Cheese;
    public GameObject Pickles;


    public GameObject infoBar;
    public GameObject leftWall;
    public GameObject killBox;
    public GameObject menu;



    public GameObject showTbun;
    public GameObject showLett;
    public GameObject showTom;
    public GameObject showBurg;
    public GameObject showBbun;
    public GameObject showCheese;
    public GameObject showPickles;

    public GameObject winBox;
    public GameObject arrow;
    public GameObject twoHits;
    public GameObject oneHits;
    public int lives = 3;
    private bool hasRun = false;
    private bool livesRun = false;




    //right



    // Use this for initialization
    void Start()
    {



        //call spawn() every 3 seconds
        InvokeRepeating("spawn", 3.0f, 3f);

        //spawn hand, infobar, leftWall, killBox, twoHits, showTbun
        Hand = Instantiate(Hand);
        infoBar = Instantiate(infoBar);
        leftWall = Instantiate(leftWall);
        killBox = Instantiate(killBox);
        twoHits = Instantiate(twoHits);
        showBbun = Instantiate(showBbun);


        //set the deaths on the killbox to 0 just incase
        killBox.GetComponent<KillBox>().setDeaths(0);

        //make sure the hand can move
        Hand.GetComponent<HandMovement>().setCanMove(true);


    }

    // Update is called once per frame
    void Update()
    {
        //call checkLives
        CheckLives();

    }

    void spawn()
    {
        //rand number to randomly pick spwan point
        rand = Random.Range(0, 4);


        switch (count)
        {
            case 0:

                /**
                 * Spawn Bottom Bun
                 **/

                //create an arrow to show where the next piece will spawn
                arrow = Instantiate(arrow, StartSpawn.position, arrow.transform.rotation);

                //create the burger piece at the spwanpoint
                BBun = Instantiate(BBun, StartSpawn.position, StartSpawn.rotation);

                //get rid of the showing of the piece and replace it with the next piece
                Destroy(showBbun);
                showBurg = Instantiate(showBurg);

                //increase the count
                count++;
                break;

            case 1:


                /**
                * Spawn Burger
                **/


                if (BBun)
                {
                    BBun.GetComponent<Rigidbody2D>().Sleep();
                    BBun.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                }

                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Burger = Instantiate(Burger, Spawn[rand].position, Spawn[rand].rotation);

                Destroy(showBurg);
                showCheese = Instantiate(showCheese);

                count++;
                break;


            case 2:


                /**
                * Spawn Cheese
                **/


                if (Burger)
                {
                    Burger.GetComponent<Rigidbody2D>().Sleep();
                    Burger.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                }

                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Cheese = Instantiate(Cheese, Spawn[rand].position, Spawn[rand].rotation);

                Destroy(showCheese);
                showTom = Instantiate(showTom);

                count++;


                break;

            case 3:


                /**
                * Spawn Tomato
                **/




                //Burger.GetComponent<Rigidbody2D>().gravityScale = 50;
                //BBun.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

                //change the burger part of this to cheese
                if (Cheese)
                {
                    Cheese.GetComponent<Rigidbody2D>().Sleep();
                    Cheese.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                }
                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Tomato = Instantiate(Tomato, Spawn[rand].position, Spawn[rand].rotation);

                Destroy(showTom);
                showPickles = Instantiate(showPickles);

                count++;
                break;



            case 4:

                /**
                * Spawn Pickles
                **/
                if (Tomato)
                { Tomato.GetComponent<Rigidbody2D>().Sleep(); }
                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Pickles = Instantiate(Pickles, Spawn[rand].position, Spawn[rand].rotation);

                Destroy(showPickles);
                showLett = Instantiate(showLett);

                count++;


                break;

            case 5:

                // Burger.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                if (Pickles)
                { Pickles.GetComponent<Rigidbody2D>().Sleep(); }
                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);
                Lettuce = Instantiate(Lettuce, Spawn[rand].position, Spawn[rand].rotation);

                Destroy(showLett);
                showTbun = Instantiate(showTbun);
                count++;
                break;

            case 6:

                //Tomato.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                if (Lettuce)
                { Lettuce.GetComponent<Rigidbody2D>().Sleep(); }
                Destroy(arrow);
                arrow = Instantiate(arrow, Spawn[rand].position, arrow.transform.rotation);

                TBun = Instantiate(TBun, Spawn[rand].position, Spawn[rand].rotation);
                count++;
                break;

            case 8:
                //call gameWin 6 seconds after last piece spawns 
                gameWin();
                count++;
                break;

            default:
                count++;
                break;

        }






    }

    private void CheckLives()
    {
        //if there are no lives left and this hasnt run yet, call gameover
        if (lives < killBox.GetComponent<KillBox>().getDeaths() && hasRun == false)
        {

            gameOver();
        }

        //if there is one hit left and hasnt run yet
        if (killBox.GetComponent<KillBox>().getDeaths() == 1 && livesRun == false)
        {
            //set the flag so it wont run again
            livesRun = true;
            //create the onehit object
            oneHits = Instantiate(oneHits);
            //destroy the twohit object
            Destroy(twoHits);
        }

        //if there are no lives left 
        if (killBox.GetComponent<KillBox>().getDeaths() == 2)
        {
            //destroy oneHits
            Destroy(oneHits);
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

        //make game over menu
        Instantiate(menu);

        if (Hand.GetComponent<Rigidbody2D>().velocity.magnitude > 0)
        {
            Hand.GetComponent<Rigidbody2D>().velocity = Hand.GetComponent<Rigidbody2D>().velocity.normalized * 0;
        }
        
    }




}
