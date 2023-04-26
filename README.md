# Unity Chainlink VRF Asset

This Unity asset utilizes the ChainSafe web3 Unity plugin to request Chainlink VRF (Verifiable Random Function) data in your Unity WebGL project. By default, this asset uses the Direct Funding VRF Consumer contract on the Polygon Mumbai network with the address `0xbD7736931920BCC87Dd296c78224ea740E7e6f62`. You can change and configure the contract address and network after importing the assets. This README will guide you through the necessary steps to set up and use this asset in your Unity project, using Unity version 2021.3.8f1.

## Prerequisites

- Unity 2021.3.8f1 or later
- Approve LINK tokens for the VRF contract on the Polygon Mumbai network
- MetaMask browser extension

## Supported Networks

- Polygon Mumbai: [0xbD7736931920BCC87Dd296c78224ea740E7e6f62](https://mumbai.polygonscan.com/address/0xbD7736931920BCC87Dd296c78224ea740E7e6f62)
- Ethereum Goerli : [0xe10c58453bcfa3514e89965157380d3d7c1059e6](https://goerli.etherscan.io/address/0xe10c58453bcfa3514e89965157380d3d7c1059e6)
- Ethereum Sepolia : [0x8753DAdC7251044f51339692eC63c009e25AeB32](https://sepolia.etherscan.io/address/0x8753dadc7251044f51339692ec63c009e25aeb32)
- BSC Testnet : [0xeb35b89EAd5207f8F94D2959D322724F70519F5F](https://testnet.bscscan.com/address/0xeb35b89ead5207f8f94d2959d322724f70519f5f)

## Setup

Follow these steps to set up the Unity project with Chainlink VRF asset:

### Step 1: Import the ChainSafe Web3 Unity Plugin

1. Download the latest release of the `web3.unitypackage` asset by ChainSafe from the [official GitHub repository](https://github.com/ChainSafe/web3.unity/releases).
2. Launch Unity and create a new project or open an existing project using Unity version 2021.3.8f1.
3. Import the downloaded `web3.unitypackage` asset by dragging it into the Unity Editor window. You can also import the asset from the `assets` directory of this repository.

### Step 2: Import the VRF Unity Asset

1. Drag and import the `vrf.unitypackage` asset from the `assets` directory of this repository.
2. Navigate to the downloaded `vrf.unitypacakge` asset file and click `Open`. This will load the `vrf.unitypackage` asset in the Unity Editor.
3. You will be prompred to relaod the sample scene. Click `Reload` to reload the scene.

### Step 3: Add WebLogin Scene

1. In the Unity Editor, navigate to `Assets > Web3Unity > Scenes`.
2. Drag the `WebLogin` asset to the Hierarchy window.

### Step 4: Configure Build Settings

1. In the Unity Editor, go to `File > Build Settings`.
2. Switch the platform to `WebGL` by selecting it and clicking `Switch Platform`.
3. Click on `Player Settings` and navigate to `Player > Resolution and Presentation`.
4. Check the `Web3GL-2020x` option under `WebGL Template`.
5. Close the Player Settings window and, in the Build Settings window, click `Add Open Scenes` to add the current scene to the build.
6. Make sure that the `WebLogin` scene is at the top of the list of scenes in the Build Settings window.
7. Click `Build and Run` to build the project and open it in a browser.

### Step 5: Approve LINK Tokens

1. Go to the LINK Token Contract for the correct network which you can find here https://docs.chain.link/docs/link-token-contracts/.
2. Click on the `Write Contract` tab in the block explorer.
3. Click on the `Connect to Web3` button and connect your MetaMask wallet.
4. Click on the `Approve` button and enter the VRF contract address and the amount of LINK tokens you want to approve.
5. Click `Write` to approve the LINK tokens.
