## Important
This patch is not 100% evolved. Because the spring is too close to the surface it melts after some actuations. 
If you want to use this patch try to place a heat resistant layer between the SMA and the surface.


## Images of the patch

Bottom            |  Whole patch |   Whole patch actuated | Front actuated
:-------------------------:|:-------------------------:|:-------------------------:|:-------------------------:
<img src="https://user-images.githubusercontent.com/82590951/187473831-52b6a7b9-ee33-41c9-88b2-97dc3ff73429.png" width="220" height="210" />|<img src="https://user-images.githubusercontent.com/82590951/187473523-e2531234-d3de-4818-8c78-11e91079b148.png" width="220" height="210" />|<img src="https://user-images.githubusercontent.com/82590951/187473690-5a0a354f-310c-444d-8cfa-75d47bd966b0.png" width="220" height="210" />|<img src="https://user-images.githubusercontent.com/82590951/187474079-26feeedf-cd29-4684-aa44-d36cfc73b15f.png" width="250" height="210" />


1. Drag the PLA and TPU 3D models into ultimaker editor (NOT the reinforcement, this gets printed seperately!)
2. Select their materials (Name of the 3D model)
3. Merge them
4. Scale them (We used 25 mm x 25 mm; height unscaled)
5. Add 2 HalfCircle clamps on the corners as in the image (You must place them by hand, since the models did not belong together)
6. Print it
7. 3D print the PLA_Reinforcement
8. 3D print the bottom part ''BottomPartSquared'' (Same size as in step 3, height can be used as needed:  
 *The bottom part may have a far smaller height as in the image &#8594; Minimum size = diameter of the spring*)
9. Cut **spring** SMA to the desired length (We used 1-2 links of the spring)
10. `Optional`: Solder 2 jumper wires to the SMA (Difficult for small sizes &#8594; Better for 4cm x 4cm or larger)
11. Stick the SMA ends into the clamps (If something breaks don't worry it gets glued anyway)
12. `For both ends`: Glue the SMA and clamp together (Add granulate around the clamp &#8594; add glue)
13. Stick the reinforcement into the frame under the surface (See image) and glue it
14. Glue bottom part to the top surface (Add granulate to the splice &#8594; add glue)
15. Power the patch for actuation (We used 5V and 1.2A)
