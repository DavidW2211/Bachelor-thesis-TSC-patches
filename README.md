# Bachelor-thesis-TSC-patches

*Summary*:
Fabrication instructions &amp; further details concerning the creation of TSC patches.

## Introduction

Texture surface change tiles (TSC tiles) are patches, that are able to change their topology. If you want to know more about TSC tiles, please feel free to read my bachelor's thesis.
In this repository we provide instructions and 3D models, for the construction of a certain TSC patch.
Like in the thesis the TSC patches are structured in 3 categories: Spikes, Bumps and Waves.  
Note that the patches consist not only of the top surface, but also a bottom part. Since the bottom parts are reused by many patches and we want to avoid dupllication we put them in the folder *BottomPart-3D-Models* and we state which one is needed for a certain patch. The *Clamps-3D-Models* folder works the same way, they are needed by lots of different patches.

Please read the following general fabrication informatin, before you continue with building a TSC.

## Setting Up &amp; Combining 3D Models

We use the Ultimaker Cura software for printing. There you only need 2 steps: 
1. Select the right material (In the name of each patch) for each part of the patch on the left side 
<img src="https://user-images.githubusercontent.com/82590951/185628026-55f0e1e7-80df-4941-8b28-101c5e1660b2.png" width="300" height="200" />
2. Select all patches that need to be merged &#8594; Right click and select merge models. They should snap together.
<img src="https://user-images.githubusercontent.com/82590951/185628018-71d602d0-4283-4541-836d-f150d90c92a8.png" width="400" height="200" />
3. 3D print the structure


## Print information

1. The top surface parts and the corresponding bottom part get printed seperately and need to be glued together
2. We recomment to use a TPU brim with the brim ALSO on the inside, because the PLA sticks more to the blue tape than TPU and this reduces breaking parts
3. Let the print cool enough, otherwise the PLA might deform while removing the print

## Glueing information

1. The parts are designed such that it is possible to add the granulate BEFORE the glue. This way the granulate soaks up the glue and it does not stick together parts that shouldn't be connected.
2. Be careful with the glue, your hands stick immediately to the surface! We recomment using a metal pin or something that doesn't glue immediately for the case that you need to replace or press down something while gluing.

## Soldering information

The fact, that the solder does not stick to the SMA is problematic. That's why we changed the soldering process a little bit:

1. Fold the tip of the jumper wire around the SMA (IMAGE)
2. Press the jumper wire shut, such that it can't move
3. Put solder around the jumper wire, such that it encapsulates the SMA.
4. If the jumper wire can't be moved by hand you are finished.

## Material Information

For all the patches we used following resources:   
1. [Industrial glue + granulate](https://www.amazon.de/-/en/Industrial-Effective-All-Purpose-Waterproof-Heat-Resistant/dp/B01NCZFZOG/ref=sr_1_5?keywords=industriekleber&qid=1661181665&sprefix=industrie%2Caps%2C97&sr=8-5) (Accessed 22.08.2022)
2. White 3D printed parts: [TPU 95A](https://www.igo3d.com/ultimaker-tpu-285-weiss-750) (Accessed 22.08.2022)
3. Blue & black 3D printed parts: [Ultimaker PLA](https://www.igo3d.com/ultimaker-3-pla) (Accessed 22.08.2022)
4. [Jumper wires](https://www.amazon.de/AZDelivery-Jumper-Wire-Cable-Parent/dp/B07KKJ69DV/ref=sr_1_1_sspa?keywords=br%C3%BCckendraht+m%C3%A4nnlich&qid=1661181306&sprefix=jumper+w%2Caps%2C94&sr=8-1-spons&psc=1&smid=A1X7QLRQH87QA3&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUExWVVTR0pWSElBOTVMJmVuY3J5cHRlZElkPUEwNTY1OTU5Mlc4S1c0WEM1SkIxWCZlbmNyeXB0ZWRBZElkPUEwNzg2NTcwMVgxTkpaS0xHUFROUiZ3aWRnZXROYW1lPXNwX2F0ZiZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU=) (Accessed 22.08.2022)
5. [Arduino Uno](https://www.amazon.com/dp/B01EWOE0UU/ref=sr_1_2_sspa?__mk_de_DE=%C3%85M%C3%85%C5%BD%C3%95%C3%91&crid=1C4FYOUBGT5BM&keywords=arduino+uno+r3&qid=1661181427&sprefix=arduino+uno+r%2Caps%2C217&sr=8-2-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUEyRTI4MUVYQUJQQUpTJmVuY3J5cHRlZElkPUEwMjE0MTg1M0tQNExKTlUwUDlRRCZlbmNyeXB0ZWRBZElkPUEwNDgzODMzMUlIN1I4WVRSM0w1UiZ3aWRnZXROYW1lPXNwX2F0ZiZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU=) (Accessed 22.08.2022)
6. [Straightening SMAs (0.5 mm)](https://www.ebay.de/itm/272744207192?_trkparms=amclksrc%3DITM%26aid%3D1110006%26algo%3DHOMESPLICE.SIM%26ao%3D1%26asc%3D20200818143230%26meid%3D8756667dcc0e49289656add78ea02dc2%26pid%3D101224%26rk%3D1%26rkt%3D2%26sd%3D273567764601%26itm%3D272744207192%26pmt%3D0%26noa%3D1%26pg%3D2047675%26algv%3DDefaultOrganicWeb&_trksid=p2047675.c101224.m-1) (Accessed 22.08.2022)
7. [Springs (65°)](https://www.ebay.de/itm/273567764601?chn=ps&var=575427231816&norover=1&mkevt=1&mkrid=707-134425-41852-0&mkcid=2&itemid=575427231816_273567764601&targetid=1404115579173&device=c&mktype=pla&googleloc=1004896&poi=&campaignid=17935704717&mkgroupid=139162549385&rlsatarget=pla-1404115579173&abcId=9301059&merchantid=7364532&gclid=Cj0KCQjw0oyYBhDGARIsAMZEuMuVkPHRHqsgRvDC3RfehDmSxC5IyUCN7cTK6KzO_mhqoJfxeMrgXL8aAvvfEALw_wcB) (Accessed 22.08.2022)
