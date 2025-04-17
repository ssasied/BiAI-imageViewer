This program requires a certain input file structure:

in the same directory as the exe:
colors.txt with formating as below:

#ebde29 #ebde29 #7b1241
#3d9c3a #7b1241
#3d9c3a

each line can hold up to 5 different hex values separated by single space

and a PhotosColorPicker folder with .jpg files.
the colors from the .txt file arent linked in any way to the images, so its our responsibility that they match
the .jpg files are read alpabeticli and assigned to the corresponting line from the .txt 
(with the index corresponding to the order of the .jpg files in the folder) 
