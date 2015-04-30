using UnityEngine;
using System.Collections;

public class RandomGenerator : MonoBehaviour {
	
	public GameObject Candy;
    public GameObject Donut;
    public GameObject IceCream;
	public int numberOfCandy = 11;
    public int numberOfDonut = 5;
    public int numberOfIceCream = 3;
	public int min = -40, max = 40;
    private ArrayList list;
	
	void Start () {
        list = new ArrayList();

        for (int i = 0; i < numberOfCandy; i++)
        {
            list.Add(Candy);
        }

        for (int i = 0; i < numberOfDonut; i++)
        {
            list.Add(Donut);
        }

        for (int i = 0; i < numberOfIceCream; i++)
        {
            list.Add(IceCream);
        }
		PlaceCubes();
	}
	
	void PlaceCubes()
	{
		for(int i = 0; i < list.Count ;i++)
		{
            Instantiate((GameObject)list[i], GeneratedPosition(), Quaternion.identity);
            transform.Rotate(0, 90, 0);
		}
	}
	Vector3 GeneratedPosition()
	{
		int x,y,z;
		x = UnityEngine.Random.Range(min,max);
		y = UnityEngine.Random.Range(1,3);
		z = UnityEngine.Random.Range(min,max);
		return new Vector3(x,y,z);
	}
}