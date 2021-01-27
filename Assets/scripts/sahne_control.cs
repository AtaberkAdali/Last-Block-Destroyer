using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne_control : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        /*if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            Lvl01();
        }
        else if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            Lvl02();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Lvl03();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            YapayZeka();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            YapayZeka02();
        }*/
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void PreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void cikiss()
    {
        Application.Quit();
    }
    public void sahneye_yonelen(string sahne_ismi)
    {
        SceneManager.LoadScene(sahne_ismi);
    }
    public void menu()
    {
        sahneye_yonelen("menü");
    }
    public void YapayZeka()
    {
        sahneye_yonelen("YapayZekaLvl01");
    }
    public void Leveller()
    {
        sahneye_yonelen("Lvls");
    }
    public void YapayZeka02()
    {
        sahneye_yonelen("YapayZekaLvl02");
    }
    public void Lvl01()
    {
        sahneye_yonelen("Lvl01");
    }
    public void Lvl02()
    {
        sahneye_yonelen("Lvl02");
    }
    public void Lvl03()
    {
        sahneye_yonelen("Lvl03");
    }
}
