# Super Push Puzzle

Super Push Puzzle is a top-down 2D puzzle game built with Unity. The game is organized into a series of levels. Each level requires the player to push crates of various colors into nodes of corresponding color. When all of the nodes have been filled the player advances to the next level.

## Getting started

Developing for this project will require Unity. In particular, you will need [Unity 2017.1](https://store.unity.com/download?ref=personal).

## Deployment

Once you have downloaded Unity and cloned the latest repository for the project you should be able to open it like any other project in Unity. This can be done by opening Unity, going to File -> Open Project..., and navigating to the project file. Simply select that as your file and it should open up in the Unity Editor.

## Versioning

This project uses [SemVer](http://semver.org/). In essence, major releases update the x of x.y.z, significant additions update the y, and minor additions, changes, or fixes update the z. 

To put this in the context of Super Push Puzzle: the game moving from development to release will constitute an update to the x of x.y.z, the game receiving additional level(s) will constitute an update to the y, and tweaks to existing levels or bug fixes will update the z.

Editing scripts to improve cleanliness, performance, or provide minor adjustments to game balance/feel is a z-type change. Editing scripts with the intent of redesigning their function or adding new scripts entirely is a y-type change.

## Contributing

If you're interesting in contributing to the project, then please note that this project uses C# and not JavaScript (or "UnityScript").

The most useful way to contribute is to create levels. To do this, I would recommend that you first play through the game in full so you can get a sense of the level design principles and to avoid repeating any existing designs. Variations are fine - exact duplicates are not. Programming knowledge is not required to design new levels, however an understanding of the Unity Editor and prefabs will be needed.

If you would like to make a pull request that includes new level(s), please name it according to the versioning guidelines above. The description should include every level added and its name.

Levels are named in the following manner: x-y, where x roughly corresponds with the difficulty level and y corresponds with the level within that difficulty. Please consult the Assets/_Scenes/ folder to get a better sense of naming. Do not skip ahead or attempt to replace existing levels. For example, if 1-1 through 1-15 exist, do not make a new level named 1-14 or a new level named 1-30. Simply make one named 1-16. 

Difficulty level dictates mechanical complexity. For example, 1-x levels only use one color while 2-x levels use two. Other mechanics may be used beyond more colors to create more difficult levels in the future. Please do not attempt to add a new DIFFICULTY level without constructing a new mechanic and creating at least 3 levels demonstrating this mechanic. 

## Authors

* **Andrew Wright** - primary developer - [roocey](https://github.com/roocey)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements 

* [kenney.nl](http://kenney.nl/) for the excellent CC-0 sprites
* Friends & family for testing Super Puzzle Push

## Contact

The simplest way to get in contact with me is to tweet me [@roocey](https://twitter.com/roocey)
