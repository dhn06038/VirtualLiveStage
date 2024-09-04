# VirtualLiveStage

The **VirtualLiveStage** repository is dedicated to creating live stages in virtual environments using Unreal Engine and Unity. This project aims to enable musicians, virtual singers, and performers to host live shows in virtual worlds and stream them online.

## Project Overview

### Engines Used
- **Unreal Engine (5.4.3)**
- **Unity**

### Folder Structure

1. **VirtualStudio**
   - This is the main project folder containing the completed Unreal Engine 5.4.3 project. It includes a demo light show synchronized to a song, showcasing the potential of virtual stage design. The light show was primarily created using the MagicQ software to design the timeline, with the option for real-time interaction between MagicQ and Unreal Engine’s light objects via the DMX plugin. The demo video was captured using Unreal’s CineCamera.

   Using MagicQ to make light's timeline
   
   <img src="https://github.com/user-attachments/assets/ed166136-eb78-4dc2-9030-ec5f39116787" width="80%" height="45%"/>

   Receiving DMX data in Unreal Engine
   
   <img src="https://github.com/user-attachments/assets/a45df2e1-8433-4fe4-b91a-c816428c5174" width="80%" height="45%"/>

   Google Drive Link for Demo video
   
   [Unreal with DMX Demo](https://drive.google.com/file/d/1RVlMKlcb47vPCjzlq-o3FS7Vb0a1jMyj/view?usp=drive_link)

3. **VLStage_Unity**
   - This folder is set up for the Unity project and contains stage modeling and a custom DMX package. For DMX integration in Unity, I am using a custom package from [igolinin's DMXtools](https://github.com/igolinin/DMXtools).

   Receiving DMX data in Unity

   <img src="https://github.com/user-attachments/assets/7a56e50c-59e4-464a-8762-f043896c3e78" width="80%" height="45%"/>


4. **VLStage_Unreal**
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
