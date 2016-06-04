using UnityEngine;
using System.Collections;

public class musicViz : MonoBehaviour {

	//no music just eject the ball up, new vector up

	//variation on cups - different shapes and sizes - Also, random ramps thrown in to fuck up the flow

	//cups are facing different directions - not all facing same direction and rotating the same way

	//cups get smaller as time goes on + change color of the cups to visualize the change

	//context - visual design + story

	//signalnoise artist

	//hot air balloons floating up - possible context for game

	//Goalie pos with music viz:

	//Pos (0, -100, 0);
	//Scale (1, 1, 1);
	
	public AudioSource music;

	public int detail = 500;
	public float amplitude = 0.1f;

	void Start() {
		
	}

	void Update() {

		Vector3 moving = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		float[] info = new float[detail];

		AudioListener.GetOutputData(info, 0); 

		float packagedData = 0.0f;

			for(int i = 0; i < info.Length; i++){
			
				packagedData += System.Math.Abs(info[i]);
			}

		moving.x = packagedData * amplitude;

		moving.y = packagedData * amplitude;

		transform.localScale = moving;

		if (!GameObject.Find ("Ball").GetComponent<ballWinCondition> ().isAlive) {
			music.Stop ();
		}
	}
}