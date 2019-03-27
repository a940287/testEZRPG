using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : Entity
{
    private void Awake()
	{
		speed = 0.5f;
	}

    // Update is called once per frame
    void Update()
    {
        moving();
    }
	
	public override void moving()
	{
		GameObject player = GameObject.FindWithTag("Player");
		if(player != null)
		{
			this.gameObject.transform.LookAt(player.transform);
			this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
	}
}
