using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapGeneration : MonoBehaviour {

public GameObject GroundPrefab;
	//  public GameObject bridge;
	//  public GameObject  spikes;
	// public int minPlatformSize = 1;
	// public int maxPlatformSize = 10;
	// public int MaxHeight = 3;
	// public int maxDrop = -3;
	// public int platforms = 100;
	// [Range (0.0f, 1f)]
	// public float hazardChance = .5f;
	// [Range (0.0f, 1f)]
	// public float bridgeChance = .1f;

	// private int blockNum = 1;
	// private int blockHeight;
	void start(){
			Vector2 position = new Vector2(0, -10);
		Instantiate(GroundPrefab, position, Quaternion.identity);
		
// 		for(int plat = 1; plat<platforms;plat++){
// 		int platformsize = Mathf.RoundToInt(Random.Range(minPlatformSize,maxPlatformSize));
// 		blockHeight=blockHeight+Random.Range(maxDrop, MaxHeight);

// 		for(int tiles = 0; tiles<platformsize; tiles++){
// 			Instantiate(groundTop, new Vector2(blockNum, blockHeight),Quaternion.identity);
// 			blockNum++;
// 		}
// 	}
}

	
	void Update(){
		
	}

}	