using UnityEngine;
using System.Collections;

public class allcontrol : MonoBehaviour {

	// Use this for initialization
	public static GameObject headone1;
	public static GameObject headone2;
	public static GameObject headone3;

	public static GameObject oneStone4;
	public static GameObject oneStone5;
	
	public static GameObject headtwo1;
	public static GameObject headtwo2;
	public static GameObject headtwo3;
	public static GameObject headtwo4;
	public static GameObject headtwo5;

	public static GameObject twoStone1;
	public static GameObject twoStone2;
	public static GameObject twoStone3;		
	
	public static GameObject headthree1;
	public static GameObject headthree2;
	public static GameObject headthree3;
	public static GameObject headthree4;
	public static GameObject headthree5;
	
	public static GameObject threeStone1;
	public static GameObject threeStone2;
	public static GameObject threeStone3;	
	
	private player characterScript;
	
	private int minateNum = 1;
	private static int meterNum = 500;
	private int nowMeterNum;
	public int speed = 3;
	
	
	private int maxScore;
	private int maxCoin;
	
//	private GamePool redGamePool;
//	private GamePool blueGamePool;
//	private GamePool yellowGamePool;
	
//	private Vector3 coinChangePosition = new Vector3(0,0,0);
	void Awake()
	{
		
	//	redGamePool = GameObject.FindGameObjectWithTag("red").GetComponent<GamePool>();		
	//	blueGamePool = GameObject.FindGameObjectWithTag("blue").GetComponent<GamePool>();
	//	yellowGamePool = GameObject.FindGameObjectWithTag("yellow").GetComponent<GamePool>();		
		
		headone1 = GameObject.Find("headone1");
		headone2 = GameObject.Find("headone2");
		headone3 = GameObject.Find("headone3");
		headone4 = GameObject.Find("headone4");
		headone5 = GameObject.Find("headone5");
		
		oneStone1 = GameObject.Find("oneStone1");
		oneStone2 = GameObject.Find("oneStone2");
		oneStone3 = GameObject.Find("oneStone3");
		oneStone4 = GameObject.Find("oneStone4");
		oneStone5 = GameObject.Find("oneStone5");
		
		headtwo1 = GameObject.Find("headtwo1");
		headtwo2 = GameObject.Find("headtwo2");		
		headtwo3 = GameObject.Find("headtwo3");		
		headtwo4 = GameObject.Find("headtwo4");		
		headtwo5 = GameObject.Find("headtwo5");	
		
		twoStone1 = GameObject.Find("twoStone1");
		twoStone2 = GameObject.Find("twoStone2");	
		twoStone3 = GameObject.Find("twoStone3");		
		
		headthree1 = GameObject.Find("headthree1");	
		headthree2 = GameObject.Find("headthree2");	
		headthree3 = GameObject.Find("headthree3");	
	
	}
	
	void Start () {
		
		//characterScript = GameObject.FindGameObjectWithTag("player").GetComponent<character>();
		//smoothfollowScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<smoothfollow>();
	
	}
	
	void Update()
	{
		////meter
		if(Time.time > minateNum)
		{
			minateNum  = minateNum + 1;
			nowMeterNum = nowMeterNum + speed;
		}
		
		if(nowMeterNum > meterNum)
		{
			meterNum = meterNum + 500;
			speed = speed + 1;
			//characterScript.SetSpeed(speed);
		}
		
		//score
		maxScore = maxScore + speed;

	}
/*	
	public void AddCoin(int num)
	{
		maxScore = maxScore + 1;
		
		if(num == 0)
		{
			redGamePool.SpawnGameObject(coinChangePosition, coinChangePosition);
		}
		else if(num == 1)
		{
			blueGamePool.SpawnGameObject(coinChangePosition, coinChangePosition);;
		}
		else if(num == 2)
		{
			yellowGamePool.SpawnGameObject(coinChangePosition, coinChangePosition);;	
		}
		
	}*/
	
	public static int GetMeter()
	{
		return meterNum;
	}

}
