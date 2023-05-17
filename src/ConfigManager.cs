// Import required namespaces
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

// Define a serializable NetworkConfig class to store network configurations
[System.Serializable]
public class NetworkConfig
{
    public int networkId;          // Network ID
    public string contractAddress; // Contract address
    public string linkTokenAddress; // LINK token contract address
    public string rpc;             // Remote procedure call address
}

// Define a serializable Config class to store multiple NetworkConfigs
[System.Serializable]
public class Config
{
    public Dictionary<string, NetworkConfig> networks; // Dictionary of network configurations
}

// Define the ConfigManager class to manage application configurations
public class ConfigManager : MonoBehaviour
{
    private static Config config; // Store the deserialized Config object

    // Initialize the ConfigManager by loading and deserializing the config file
    public static void Initialize()
    {
        TextAsset configFile = Resources.Load<TextAsset>("config"); // Load the config file
        config = JsonConvert.DeserializeObject<Config>(configFile.text); // Deserialize the config file
    }

    // Get the NetworkConfig object for the specified network ID
    public static NetworkConfig GetNetworkConfig(int networkId)
    {
        // Initialize the ConfigManager if it has not been initialized
        if (config == null)
        {
            Initialize();
        }

        // Iterate through the network configurations to find the matching network ID
        foreach (var network in config.networks.Values)
        {
            if (network.networkId == networkId)
            {
                return network; // Return the matching NetworkConfig object
            }
        }

        // Log an error if the network ID is not found
        Debug.LogError("Network ID not found: " + networkId);
        return null; // Return null if the network ID is not found
    }
}
