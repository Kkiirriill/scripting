using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource audioSource;
    public audioClip damageSound;
private int health = 10;

public void TakeDamage(int Damage)
{
health -= Damage;
    if health > 0
{
    audioSource.PlayOneShot(damageSound);
}
else
{
int sceneIndex = SceneManager.GetActivScene().buildIndex;
SceneManager.LoadScene(sceneIndex);
}
print("здоровье игрока: " + health);
}
}