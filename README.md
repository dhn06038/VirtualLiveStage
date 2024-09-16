# VirtualLiveStage

The **VirtualLiveStage** repository is dedicated to creating live stages in virtual environments using Unreal Engine and Unity. This project aims to enable musicians, virtual singers, and performers to host live shows in virtual worlds and stream them online.

## Project Overview

### Engines Used
- **Unreal Engine (5.4.3)**
- **Unity (2022.3.20f1)**

### Folder Structure

### 1. VirtualStudio
   - This is the main project folder containing the completed Unreal Engine 5.4.3 project. It includes a demo light show synchronized to a song, showcasing the potential of virtual stage design. The light show was primarily created using the MagicQ software to design the timeline, with the option for real-time interaction between MagicQ and Unreal Engine’s light objects via the DMX plugin. The demo video was captured using Unreal’s CineCamera.

   Using MagicQ to make light's timeline
   
   <img src="https://github.com/user-attachments/assets/ed166136-eb78-4dc2-9030-ec5f39116787" width="80%" height="45%"/>

   Receiving DMX data in Unreal Engine
   
   <img src="https://github.com/user-attachments/assets/a45df2e1-8433-4fe4-b91a-c816428c5174" width="80%" height="45%"/>

   Google Drive Link for Demo video(Recorded with a cine camera).
   
   [Unreal with DMX Demo](https://drive.google.com/file/d/1RVlMKlcb47vPCjzlq-o3FS7Vb0a1jMyj/view?usp=drive_link)

   <img src="https://github.com/user-attachments/assets/b4a2e747-0e07-40f4-9d4a-5428e4a075a0" width="80%" height="45%"/>


### 3. VLStage_Unity
   - This folder is set up for the Unity project and contains stage modeling and a custom DMX package. For DMX integration in Unity, I am using a custom package from [igolinin's DMXtools](https://github.com/igolinin/DMXtools).

   - It works on HDRP environments.(For volumetric of lights)

   **Add 6 types of lights and effects in Unity**

   **Sharpy, Wash**
   
   - Sharpy: Sharpy is a high-intensity beam light known for its sharp and concentrated beams of light. It creates precise, narrow beams that can be used for focused lighting on performers or to create dramatic aerial effects.

   - Wash: Wash lights are used for wide, even coverage across the stage. They provide soft, diffused light that can fill the entire stage with color or general illumination.

   <img src="https://github.com/user-attachments/assets/4e7b9558-fd71-4a8f-877c-d102dc754c89" width="80%" height="45%"/>

   **Strobe, Static**

   - Strobe: Strobe lights produce rapid, intense flashes of light that create a sense of motion or freezing action on stage. It can also simulate the effect of high-energy moments in a performance.

   - Static: Static lights remain fixed in place and provide a continuous, steady light on a particular area or object.

   <img src="https://github.com/user-attachments/assets/5354303a-c466-48b3-9916-b68d16791e49" width="80%" height="45%"/>

   **Pyro, Laser**

   - Pyro: Pyro refers to pyrotechnic effects that create controlled bursts of fire, sparks, or explosions on stage. It adds a dramatic and intense visual impact.

   - Laser: Laser lights emit concentrated, highly focused beams of light, usually in a variety of colors. Lasers can create intricate patterns, geometric shapes, or straight beams that can cut through smoke to create a mesmerizing light show.

   <img src="https://github.com/user-attachments/assets/fd624814-e860-46fb-9deb-3013b5ee786b" width="80%" height="45%"/>

   **Connect with MagicQ(DMX)**

   <img src="https://github.com/user-attachments/assets/145c51be-7495-42e3-9fc7-20008e06fa28" width="80%" height="45%"/>

   **LED Screen(Splitted)**

   For a more realistic LED screen representation, [llcheesell's LEDScreenShader](https://github.com/llcheesell/LEDScreenShader) is used.

   <img src="https://github.com/user-attachments/assets/4347f37c-2087-43b6-9a0a-d7a809848fa9" width="80%" height="45%"/>

   <img src="https://github.com/user-attachments/assets/b8b8dcc9-d11f-40f4-b16f-b83a4dee17db" width="80%" height="45%"/>


### 4. VLStage_Unreal
   - This folder contains the Unreal Engine project, including stage modeling and the DMX plugin setup to connect MagicQ with Unreal Engine. I am using Unreal’s built-in DMX plugin to achieve this connection.


### Lighting Implementation with DMX and MagicQ

For stage lighting, this project uses the DMX tool MagicQ by Chamsys. MagicQ offers several advantages for implementing a stage lighting system within Unreal and Unity environments:

- **Precision**: MagicQ provides precise control over lighting, ideal for creating intricate light shows.
- **Integration**: Seamless integration with Unreal Engine through its DMX plugin allows for real-time interaction between MagicQ and Unreal’s light objects.
- **Flexibility**: MagicQ supports both timeline-based light shows and real-time interaction, offering a versatile approach to stage lighting.

In Unity, the custom DMX package from [igolinin](https://github.com/igolinin/DMXtools) is used to achieve similar integration, allowing for the creation of dynamic light shows within the Unity environment.

### Future Work

I plan to continue working on the Unity project, comparing the strengths and weaknesses of both Unreal Engine and Unity in the context of virtual stage design. This comparison will help identify the best practices for creating immersive virtual live performances in both environments.

Stay tuned for updates as I continue to explore and develop this exciting project!
