using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class User
{
    public string username;
    [SerializeField] private string password;

    public User(string name, string pass)
    {
        username = name;
        password = pass;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (!obj.GetType().Equals(this.GetType()))
        {
            return false;
        }
        User other = (User)obj;
        if (!other.username.ToLower().Equals(username.ToLower()))
        {
            return false;
        }
        if (!other.password.Equals(password))
        {
            return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return username;
    }
}