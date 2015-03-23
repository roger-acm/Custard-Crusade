using UnityEngine;
using System.Collections;

public class RandomGenerator : MonoBehaviour {
	
	public GameObject Sweet;
	public int numberOfCubes = 10;
	public int min = -40, max = 40;
	
	void Start () {
		PlaceCubes();
	}
	
	void PlaceCubes()
	{
		for(int i = 0; i < numberOfCubes;i++)
		{
            Instantiate(Sweet, GeneratedPosition(), Quaternion.identity);
		}
	}
	Vector3 GeneratedPosition()
	{
		int x,y,z;
		x = UnityEngine.Random.Range(min,max);
		y = UnityEngine.Random.Range(1,max);
		z = UnityEngine.Random.Range(min,max);
		return new Vector3(x,y,z);
	}
}