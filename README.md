
![3 Experience Love Logo](https://github.com/clionachee/experience/assets/94758696/b42765f6-ac1d-4fce-b457-4487f2c42ed9)


![Screenshot 2024-01-22 004802](https://github.com/clionachee/experience/assets/94758696/4fca5b2b-95d0-40c4-b139-0d8d51fc9596)

**Technologies Used:**

1. **Ethereum Blockchain:**
   - The project is grounded in the Ethereum blockchain, providing a secure and decentralized foundation for transactions, asset ownership, and user interactions.

2. **Chainlink VRF:**
   - The ethereal dance of unpredictability is orchestrated by Chainlink VRF, adding an element of secure randomness to various aspects of the metaverse.

3. **Webgl+XR Plugin:**
   - To bridge the realms between virtual and tangible, the Webgl+XR Plugin creates an immersive environment accessible across diverse devices and platforms.

4. **Unity Game Engine:**
   - Unity serves as the canvas for the metaverse, allowing the creation of scenic landscapes, dark skies, and mountains, elevating the visual and interactive experience.

5. **Chainsafe SDK:**
   - The integration of Chainsafe SDK contributes to the safety and security of transactions within the metaverse, enhancing the overall trustworthiness of the virtual environment.

**Integration:**

1. **Ethereum and Chainlink Synergy:**
   - Ethereum and Chainlink are seamlessly integrated to ensure secure and transparent transactions. Chainlink VRF operates as an oracle, providing verifiable randomness while interacting harmoniously with the Ethereum blockchain.

2. **Webgl+XR Plugin Harmony:**
   - The Webgl+XR Plugin is carefully woven into the Unity game engine, creating an immersive and accessible virtual space. This integration ensures a fluid experience for users exploring the metaverse.

3. **Chainsafe SDK Security Layer:**
   - Chainsafe SDK acts as a security layer, complementing the Ethereum blockchain. Its integration strengthens the overall safety of transactions within the metaverse, aligning with the project's commitment to trust and transparency.

**Notable Considerations:**

1. **Meaningful Asset Trading Algorithm:**
   - The algorithm governing asset trading after deep talks is designed to prioritize meaningful connections. It ensures that virtual assets hold sentimental value, enriching the trading experience and reflecting the depth of interactions.

2. **User-Controlled Conversations Architecture:**
   - The architecture empowering users to reject conversations is designed with simplicity and user-centricity in mind. It allows for seamless control, emphasizing a comfortable and empowered user experience.

3. **Chainlink VRF Panel Integration:**
   - The unlickable Chainlink VRF panel within the demo provides a glimpse into the secure transaction functionalities. Its integration serves as a notable step towards ensuring the unpredictability and fairness of virtual experiences.

**Benefits of Partner Technologies:**

   - **Chainlink VRF:** Ensures secure and verifiable randomness, adding an enriching layer of unpredictability to interactions.
   
   - **Chainsafe SDK:** Strengthens the security of transactions, aligning with the project's commitment to safe and trustworthy virtual experiences.

**Future Iterations:**

   - Future development involves refining the demo, addressing any existing limitations, and further enhancing the metaverse's functionalities. The goal is to create a seamlessly functioning, secure, and deeply engaging space for users.



_________________________________________________________________________________________________________

Previous Check-Ins:

Tech stack in plan to use:
Chainlink VRF with Unity
Unity Game Engine
Gravity Sketch in Meta Quest 3

Short and sweet description:
'Experience Love,' a metaverse space using Unity and Chainlink VRF for XR where customizable experiences await. Social data fuels immersive customized exploration, while VRF powers asset transactions. It accompanies people to explore their worth, which AI can't replace yet.

About the project:

Experience Love is a metaverse space integrating Unity with Chainlink's VRF Asset, being a practical and engaging 3D motion experience for users to customize quests and feel loveable. Users navigate love-themed challenges using Chainlink's secure randomness, ensuring unique experiences. Upon entry, user data from social platforms is connected with consent to generate special and custom collaborative puzzle-solving and emotional scenarios for exploration and love. This step is aided by another AI integration and may be altered at an early stage. The Unity Chainlink VRF Asset not only adds authenticity but also introduces revenue streams, enabling tokenized events and in-app transactions of the metaverse assets. This practical integration positions Experience Love as a human-focused and revenue-generating immersive space, emphasizing harmony between beings, nature, and technologies.
_________________________________________________________________________________________________________


# Tech Stack 1: Unity Chainlink VRF Asset

This Unity asset utilizes the ChainSafe web3 Unity plugin to request Chainlink VRF (Verifiable Random Function) data in your Unity WebGL project. By default, this asset uses the Direct Funding VRF Consumer contract on the Polygon Mumbai network with the address `0xbD7736931920BCC87Dd296c78224ea740E7e6f62`. You can change and configure the contract address and network after importing the assets. This README will guide you through the necessary steps to set up and use this asset in your Unity project, using Unity version 2021.3.8f1.

## Prerequisites

- Unity 2021.3.8f1
- Approve LINK tokens for the VRF contract on the desired network
- MetaMask browser extension

## Supported Networks

- Polygon Mumbai: [0x9472fBaE5c692DD391725B529932f8939f8a5Ad1](https://mumbai.polygonscan.com/address/0x9472fBaE5c692DD391725B529932f8939f8a5Ad1)
- Ethereum Goerli : [0xFB34a709B04314651aB63bb96007E5B1e4f692c5](https://goerli.etherscan.io/address/0xFB34a709B04314651aB63bb96007E5B1e4f692c5)
- Ethereum Sepolia : [0x67965649a77AED694F38019a3e8321c496130424](https://sepolia.etherscan.io/address/0x67965649a77AED694F38019a3e8321c496130424)
- BSC Testnet : [0xC50f1ce56c664262c2F15590c1Ff73D8756200f3](https://testnet.bscscan.com/address/0xC50f1ce56c664262c2F15590c1Ff73D8756200f3)

## Setup

Follow these steps to set up the Unity project with Chainlink VRF asset:

### Step 1: Import the ChainSafe Web3 Unity Plugin

1. Download the latest release of the `web3.unitypackage` asset by ChainSafe from the [official GitHub repository](https://github.com/ChainSafe/web3.unity/releases).
2. Launch Unity and create a new project or open an existing project using Unity version 2021.3.8f1.
3. Import the downloaded `web3.unitypackage` asset by dragging it into the Unity Editor window. You can also import the asset from the `assets` directory of this repository.

### Step 2: Import the VRF Unity Asset

1. Drag and import the `vrf-chainsafe.unitypackage` asset from the `assets` directory of this repository.
2. Navigate to the downloaded `vrf-chainsafe.unitypacakge` asset file and click `Open`. This will load the `vrf-chainsafe.unitypackage` asset in the Unity Editor.
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

![VRF Unity](./vrf-unity.png)
