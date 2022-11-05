using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlyerController : MonoBehaviour
{
    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite emptyHeart;
    [SerializeField] private Image[] lives; // массив максимальное количество жизней
    [SerializeField] private int health; // текущее количество жизней
    [SerializeField] private int num0Lives;// количество жизней всего
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject win;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullHeart;
            }
            else lives[i].sprite = emptyHeart;
            if (i < num0Lives)
            {
                lives[i].enabled = true;
            }
            else lives[i].enabled = false;
        }
        if (health > num0Lives)
        {
            health = num0Lives; 
        }
        if (transform.position.y < -10)
        {
            Dead();
        }

    }
    public void ChengeHealth(int count)
    {
        health += count;

        if (health <= 0)
        {
            Dead();
        }   
    }
    private void Dead()
    {
        gameOver.SetActive(true);
        GetComponent<Player_Move>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
    private void Win()
    {
        win.SetActive(true);
        GetComponent<Player_Move>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            ChengeHealth(-1);
        }
        if (collision.CompareTag("Hill"))
        {
            ChengeHealth(+1);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Finish"))
        {
            Win();
        }
    }
}
