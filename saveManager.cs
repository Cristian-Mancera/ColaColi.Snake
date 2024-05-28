using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveManager
{
    public static void SavePlayerData(Player player)
    {

        PlayerData playerData = new PlayerData(player);
        string datapath = Application.persistentDataPath + "/playerData.save";
        FileStream fileStream = new FileStream(datapath, FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();
    }

    public static PlayerData loadPlayerData()
    {

        string datapath = Application.persistentDataPath + "/playerData.save";
        if (File.Exists(datapath))
        {

            FileStream fileStream = new FileStream(datapath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return playerData;

        }
        else
        {

            Debug.Log("no se encontraron datos de guardado");
            return null;
        }


    }


}
