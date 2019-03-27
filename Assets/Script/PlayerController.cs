using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moving();
		rotating();
    }
	
	public override void moving()
	{
		if(Input.GetKey(KeyCode.W))
		{
			this.transform.Translate(Vector3.forward*speed);
		}
		
		if(Input.GetKey(KeyCode.A))
		{
			this.transform.Translate(Vector3.left*speed);
		}
		
		if(Input.GetKey(KeyCode.S))
		{
			this.transform.Translate(Vector3.back*speed);
		}
		
		if(Input.GetKey(KeyCode.D))
		{
			this.transform.Translate(Vector3.right*speed);
		}
	}
	
	private void rotating()
	{
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Rotate(0f,-2f,0f);
		}
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Rotate(0f,2f,0f);
		}
	}
	
	private void OnCollisionEnter(Collision other)
	{
		Entity otherEntity = other.gameObject.GetComponent<Entity>();
		if(otherEntity != null)
		{
			Damage(otherEntity.AttackPower);
			Debug.Log("collision!!");
		}
	}
}




























