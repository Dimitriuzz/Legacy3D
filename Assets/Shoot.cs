using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	[Header("Левые мячи")]
	public GameObject 	ЛевыйМяч;
	public float 		СкоростьЛевогоМяча;

	[Header("Правые мячи")]
	public GameObject 	ПравыйМяч;
	public float 		СкоростьПравогоМяча;

	[Space(10)]
	public float 		Скорострельность;

	float time;

	void Update () 
	{

		time += Time.deltaTime;

		if(Input.GetMouseButton(0))
		{

			if(time >= Скорострельность)
			{
				if(ЛевыйМяч == null) return;
				Rigidbody bullet = Instantiate(ЛевыйМяч, transform.position + transform.forward * 0.5f + new Vector3(0, -0.4f, 0), Quaternion.identity).GetComponent<Rigidbody>();
				bullet.velocity = transform.TransformDirection(Vector3.forward * СкоростьЛевогоМяча);
				time = 0;
			}
		}

		if(Input.GetMouseButton(1))
		{
			if(time >= Скорострельность)
			{
				if(ПравыйМяч == null) return;

				Rigidbody bullet = Instantiate(ПравыйМяч, transform.position + transform.forward * 0.5f + new Vector3(0, -0.4f, 0), Quaternion.identity).GetComponent<Rigidbody>();
				bullet.velocity = transform.TransformDirection(Vector3.forward * СкоростьПравогоМяча);
				time = 0;
			}
		}

	}
}
