using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class _MyScript : MonoBehaviour {
	public Text timer;

	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt("BestTime",0);
		StartCoroutine("Timer");


	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	public IEnumerator Timer()
	{
		for (int i=0;;i++) {
			for(int j=0;j<60;j++)
			{
			if(j>9)
			{
					if(i<9)
					{
					timer.text=" 0"+i+":"+j;
					}
					else{
						timer.text=" "+i+":"+j;
					}
			}
			else{
					if(i<9)
					{
					timer.text=" 0"+i+":0"+j;
					}
					else
					{
						timer.text=" "+i+":0"+j;
					}
			}
				int bestscr=i*60+j;
				PlayerPrefs.SetInt("Time",bestscr);

				if(bestscr>PlayerPrefs.GetInt("BestTime"))
				{
					PlayerPrefs.SetInt("BestTime",bestscr);
//					
					}
				
			

			yield return new WaitForSeconds(1.0f);

		}
			
		}
		
		
		
	}



}
