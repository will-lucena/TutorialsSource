using UnityEngine;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;

public static class Persistance
{
    public static List<User> users = new List<User>();

    //it's static so we can call it from anywhere
    public static string Save(User user)
    {
        users.Add(user);
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<User>));
        FileStream file = File.Create(Application.persistentDataPath + "/Users.data");
        serializer.WriteObject(file, Persistance.users);
        file.Dispose();
        return Application.persistentDataPath + "/";
    }

    public static List<User> Load()
    {
        if (File.Exists(Application.persistentDataPath + "/Users.data"))
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<User>));
            FileStream file = File.Open(Application.persistentDataPath + "/Users.data", FileMode.Open);
            Persistance.users = (List<User>)serializer.ReadObject(file);
            file.Dispose();
        }
        return users;
    }
}