using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
	public Transform pointPrefab;
	[Range(10, 100)]
	public int resolution = 10;

	Transform[] points;

	void Awake()
	{


		float step = 2f / resolution;
		Vector3 scale = Vector3.one * step;
		Vector3 position;
		position.z = 0f;
		position.y = 0f;
		points = new Transform[resolution];
		for (int i = 0; i < points.Length; i++)
		{
			
			Transform point = Instantiate(pointPrefab);
			points[i] = point;
			point.SetParent(transform, false);
			position.x = (i + 0.5f) * step - 1f;
			//position.y = position.x * position.x;
			//position.y = position.x * position.x * position.x;
			point.localPosition = position;
			point.localScale = scale;
		}
	}

	void FixedUpdate()
	{
		for (int i = 0; i < points.Length; i++)
		{ 
			
			//Each iteration, we begin by getting a reference to the current array element. Then we retrieve that point's position.
			Transform point = points[i];
			Vector3 position = point.localPosition;
			//position.y = position.x * position.x * position.x;
			//Because vector's aren't objects, we only adjusted the local variable. To apply it to the point, we have to set its position again.
			
		
			position.y = Mathf.Sin(Mathf.PI * (position.x + Time.time));
			point.localPosition = position;
		}
	}

	//private void FixedUpdate()
	//{
	//	for (int i = 0; i < this.points.Length; i++)
	//	{
	//		var point = this.points[i];
	//		var position = point.localPosition;
	//		position.y = Mathf.Sin(Mathf.PI * (position.x + Time.time));
	//		point.localPosition = position;
	//	}
	//}
}
