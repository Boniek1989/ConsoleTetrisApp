16.03.2024
Welcome to my console "kind of" tetris game project.

This is just a beginning.

Right now program runs like :

1) Draw tetris game layer,
2) Draw a 5 elements long brick which is running down the scene,
3) Also added controllers to move left and right,

Clue thing about this project:

I've invented connection between drawing bricks on console and two dimension array. Box collider depends on my array. It works like that :

1) Default array value is set to 0,
2) If brick reach bottom, drew element value is changing to 1,
3) If brick reach another brick (is colliding) value is changing to 1 and loop breaks, 

18.03.2024
1) Created new branch for rotator issue,
2) Changed updating string method from WriteAt " " to Console.Clear - in case to stop artifacts on screen.
3) New files for old classes in case to better code maintenance.
