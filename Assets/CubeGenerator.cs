using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
	public GameObject cubePrefab;//キューブのPrefab
	private float delta = 0;//時間計測用の変数
	private float span = 1.0f;//生成間隔
	private float genPosX = 12;//キューブ生成：X座標
	private float offsetY = 0.3f;//キューブの生成位置オフセット
	private float spaceY = 6.9f;//キューブの縦方向の間隔
	private float offsetX = 0.5f;//キューブの生成位置オフセット
	private float spaceX = 0.4f;//キューブの横方向の間隔
	private int maxBlockNum = 4;//ブロックの最大個数
								// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		this.delta += Time.deltaTime;
		if (this.delta > this.span)
		{
			this.delta = 0;
			int n = Random.Range(1, maxBlockNum + 1);
			for (int i = 0; i < n; i++)
			{
				GameObject go = Instantiate(cubePrefab) as GameObject;
				go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
			}
			this.span = this.offsetX + this.spaceX * n;
		}
	}
}