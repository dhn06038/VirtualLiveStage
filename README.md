# VirtualLiveStage

**VirtualLiveStage** is a project aimed at creating live performances in virtual environments using Unreal Engine and Unity. The goal is to enable musicians, virtual singers, and performers to host live shows in digital worlds and stream them to audiences online.
 
## Project Overview

### Engines Used
- **Unreal Engine (5.4.3)**
- **Unity (2022.3.20f1)**
- **MagicQ (v1.9.5.6)**

### Folder Structure

### 1. VirtualStudio
   - This is the project folder containing the completed Unreal Engine 5.4.3 project. It includes a demo light show synchronized to a song, showcasing the potential of virtual stage design. The light show was primarily created using the MagicQ software to design the timeline, with the option for real-time interaction between MagicQ and Unreal Engine’s light objects via the DMX plugin. The demo video was captured using Unreal’s CineCamera.

  
      **Receiving DMX data in Unreal Engine**

      <img src="https://github.com/user-attachments/assets/366a6aee-6e42-4ac0-8eae-218da7a2bf3d" width="80%" height="45%"/>
   
      **Google Drive Link for Demo video(Recorded with a cine camera).**
   
      [Unreal with DMX Demo](https://drive.google.com/file/d/1RVlMKlcb47vPCjzlq-o3FS7Vb0a1jMyj/view?usp=drive_link)

      <img src="https://github.com/user-attachments/assets/b4a2e747-0e07-40f4-9d4a-5428e4a075a0" width="80%" height="45%"/>



### 2. VLStage_Unity
   - This folder is set up for the Unity project and contains stage modeling and a custom DMX package. For DMX integration in Unity, I am using a custom package from [igolinin's DMXtools](https://github.com/igolinin/DMXtools).

   - It works on HDRP environments.(For volumetric of lights)

   - **Add 6 types of lights and effects in Unity**

      **Sharpy, Wash**
   
      - Sharpy: Sharpy is a high-intensity beam light known for its sharp and concentrated beams of light. It creates precise, narrow beams that can be used for focused lighting on performers or to create dramatic aerial effects.

      - Wash: Wash lights are used for wide, even coverage across the stage. They provide soft, diffused light that can fill the entire stage with color or general illumination.

      <img src="https://github.com/user-attachments/assets/0b28e1f0-2c5d-48f2-bb41-2b789d62d22c" width="80%" height="45%"/>

      **Strobe, Static**

      - Strobe: Strobe lights produce rapid, intense flashes of light that create a sense of motion or freezing action on stage. It can also simulate the effect of high-energy moments in a performance.

      - Static: Static lights remain fixed in place and provide a continuous, steady light on a particular area or object.

      <img src="https://github.com/user-attachments/assets/8baf93ee-7708-4000-8338-4b46b0237a0f" width="80%" height="45%"/>

      **Pyro, Laser**

      - Pyro: Pyro refers to pyrotechnic effects that create controlled bursts of fire, sparks, or explosions on stage. It adds a dramatic and intense visual impact.

      - Laser: Laser lights emit concentrated, highly focused beams of light, usually in a variety of colors. Lasers can create intricate patterns, geometric shapes, or straight beams that can cut through smoke to create a mesmerizing light show.

      <img src="https://github.com/user-attachments/assets/074037b9-85bd-4c22-b87f-5c74c63f4db1" width="80%" height="45%"/>

      **Connect with MagicQ(DMX)**

      <img src="https://github.com/user-attachments/assets/1be1631b-bc4c-477a-9a38-c4a617d3e7cc" width="80%" height="45%"/>

      **LED Screen(Splitted)**

      For a more realistic LED screen representation, [llcheesell's LEDScreenShader](https://github.com/llcheesell/LEDScreenShader) is used.

      <img src="https://github.com/user-attachments/assets/50e9df76-28d2-4ebd-a275-511d16f62e3d" width="80%" height="45%"/>

      <img src="https://github.com/user-attachments/assets/c9e29eb2-fb36-46ef-aa3d-0a48464513a7" width="80%" height="45%"/>

      Each panel can transmit different screens
   
      <img src="https://github.com/user-attachments/assets/6e29e502-f97b-4d2e-a858-e14bf66bc55a" width="80%" height="45%"/>


### Lighting Implementation with DMX and MagicQ

<img src="https://github.com/user-attachments/assets/fe657a72-d195-45cf-ba60-8a09e1843c89" width="80%" height="45%"/>

For stage lighting, this project uses the DMX tool MagicQ by Chamsys. MagicQ offers several advantages for implementing a stage lighting system within Unreal and Unity environments:

- **Precision**: MagicQ provides precise control over lighting, ideal for creating intricate light shows.
- **Integration**: Seamless integration with Unreal Engine and Unity through the DMX plugin, and package.
- **Flexibility**: MagicQ supports both timeline-based light shows and real-time interaction, offering a versatile approach to stage lighting.


### Future Work

 Ongoing development will compare the strengths and weaknesses of Unreal Engine and Unity in virtual stage design. This comparison will help identify best practices for creating immersive virtual live performances in both environments.
 
 Currently developing a system that integrates motion capture with the virtual stage, allowing for real-time performance synchronization.
