using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	public AudioSource efxSource;
    public AudioSource efxMusic;
    public AudioClip backgroundmusic;
    public AudioClip boss_bg;
    public AudioClip button_clicked;
    public AudioClip defeat;
    public AudioClip victory;
    public AudioClip mainmenu;
    public AudioClip bubble_die;
    public AudioClip bubble_dmg;
    public AudioClip cactus_die;
    public AudioClip cactus_water;
    public AudioClip cactus_walls;
    public AudioClip lamp_swap;
    public AudioClip ball_swap;
    public AudioClip star_die;
    public AudioClip star_switch;
    public AudioClip ball_die;

    public static sound instance = null;

	// Use this for initialization
	void Awake () {

		  //Check if there is already an instance of SoundManager
            if (instance == null) {
                //if not, set it to this.
                instance = this;
            }
            //If instance already exists:
            else if (instance != this){
                //Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
                Destroy (gameObject);
            }

            //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
            DontDestroyOnLoad (gameObject);
	
	}
	
	public void mm(){
        if(efxMusic.clip == mainmenu){

        }
        else{
            efxMusic.clip = mainmenu;
            efxMusic.Play();

        }
    }
    public void boss(){
        if(efxMusic.clip == boss_bg){
            
        }
        else{
            efxMusic.clip = boss_bg;
            efxMusic.Play();

        }
    }
    public void bg(){
        if(efxMusic.clip == backgroundmusic){

        }
        else{
            efxMusic.clip = backgroundmusic;
            efxMusic.Play();

        }
    }
     public void defeated(){

            efxSource.clip = defeat;
            efxSource.Play();
    }
    public void victorious(){

            efxSource.clip = victory;
            efxSource.Play();
    }
    public void buttonclick(){

            efxSource.clip = button_clicked;
            efxSource.Play();
    }
    public void swaplamp(){

            efxSource.clip = lamp_swap;
            efxSource.Play();
    }
    public void ballswap(){

            efxSource.clip = ball_swap;
            efxSource.Play();
    }
    public void balldie(){

            efxSource.clip = ball_die;
            efxSource.Play();
    }
    public void bubbledie(){

    		efxSource.clip = bubble_die;
            efxSource.Play();

    }
     public void bubbledmg(){

            efxSource.clip = bubble_dmg;
            efxSource.Play();

    }
    public void stardie(){
    	efxSource.clip = star_die;
           efxSource.Play();

    }
    public void starswitch(){
    	efxSource.clip = star_switch;
           efxSource.Play();

    }
    public void cactuswalls(){
    	efxSource.clip = cactus_walls;
           efxSource.Play();

    }
    public void fallingwater(){
    	efxSource.clip = cactus_water;
           efxSource.Play();

    }
    public void cactusdie(){
    	efxSource.clip = cactus_die;
           efxSource.Play();

    }
    

}
