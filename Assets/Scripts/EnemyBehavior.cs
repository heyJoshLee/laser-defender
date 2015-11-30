using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public GameObject projectile;
	public float health = 150;
	public float projectileSpeed = 10f;
	public float shootsPerSecond = 0.5f;

	void OnTriggerEnter2D(Collider2D col) {
		Projectile missle = col.gameObject.GetComponent<Projectile>();
		if (missle) {
			health -= missle.GetDamage();
			missle.Hit();
			if (health<= 0) {
				Destroy(gameObject);
			}
			Debug.Log("Hit by a projectile");
		}
	}
	
	void Update() {
		float probability = Time.deltaTime * shootsPerSecond;
		if (Random.value < probability) {
			Fire ();
		}
		
	}
	
	void Fire() {
		Vector3 startPostion = transform.position + new Vector3(0, -1, 0);
		GameObject missile = Instantiate(projectile, startPostion, Quaternion.identity) as GameObject;
		missile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -projectileSpeed);
	}

}
