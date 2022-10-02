# Folding Spike Base

## Important
This patch is not 100% evolved. Because the spring is too close to the surface it melts after some actuations. 
If you want to use this patch you need to add a heat resistant layer, e.g., tape between the SMA and the 3D print


## Images of the patch

Bottom            |  Front |   Actuated front | Actuated whole patch
:-------------------------:|:-------------------------:|:-------------------------:|:-------------------------:
<img src="https://user-images.githubusercontent.com/82590951/187470699-6c37bed9-63e5-4a2c-96c5-48a4292edc27.png" width="220" height="200" />|<img src="https://user-images.githubusercontent.com/82590951/187471089-67c02678-7f5c-45fa-b5af-7fa69df8c2ec.png" width="250" height="200" />|<img src="https://user-images.githubusercontent.com/82590951/187470809-792c7e49-da39-4a0b-becd-799f348f21a8.png" width="250" height="200" />|<img src="https://user-images.githubusercontent.com/82590951/187471326-dbd182d8-4211-4000-a6bb-9bf3aa6cdfb4.png" width="250" height="200" />

## Instructions

1. Drag the PLA and TPU 3D models into ultimaker editor (NOT the reinforcement, this gets printed seperately!)
2. Select their materials (Name of the 3D model)
3. Merge them
4. Scale them (We used 25 mm x 25 mm; height unscaled)
5. Add 2 HalfCircle clamps on the corners as in the image (You must place them by hand, since the models did not belong together)
6. Print it
7. 3D print the PLA_Reinforcement (Same percentage scale as other parts)
8. 3D print the bottom part ''BottomPartSquared'' (Same size as in step 3, height can be used as needed:  
 *The bottom part may have a far smaller height as in the image &#8594; Minimum size = diameter of the spring*)
9. Add heat resistant layer, e.g., heat resistant tape (Otherwise the patch melts)
10. Cut **spring** SMA to the desired length (We used 1-2 links of the spring)
11. `Optional`: Solder 2 jumper wires to the SMA (Difficult for small sizes &#8594; Better for 4cm x 4cm or larger)
12. Stick the SMA ends into the clamps (If something breaks don't worry it gets glued anyway)
13. `For both ends`: Glue the SMA and clamp together (Add granulate around the clamp &#8594; add glue)
14. Stick the reinforcement into the frame under the surface (See image) and glue it
15. Glue bottom part to the top surface (Add glue → press top surface to bottom part)
16. Power the patch for actuation (We used 5V and 1.2A)
