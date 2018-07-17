using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    private string username;
    private string password;

    public void setUsername(string text)
    {
        username = text;
        Debug.Log(username);
    }

    public void setPassword(string text)
    {
        password = text;
        Debug.Log(password);
    }

    public void createUser()
    {
        Debug.Log(Persistance.Save(new User(username, password)));
    }

    public void login()
    {
        User newUser = new User(username, password);
        Persistance.Load();
        foreach(User user in Persistance.users)
        {
            if (newUser.Equals(user))
            {
                Debug.Log("Hello " + user);
            }
        }
    }
}
