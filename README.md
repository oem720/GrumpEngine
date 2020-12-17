# Welcome to GrumpEngine
GrumpEngine is an 2D text based engine developed by Owen Meyers and Cameron Taylor. This engine allows a developer to create their own text adventure game through easy to use forms and rudimentary coding. You can join our [Discord](https://discord.gg/Susvb7VE7E) where we are happy to help if you have any questions. Keep in mind that this is a personal project that we are making public. We will try and update with new content and fix bugs, but this is not something "official". Please try your own hand at this project before asking for help though.

# Game Development
Throughout this section we will go over how to use the forms, create new and edit existing entities, and share your project with your friends. Developing new editings and applying them to the forms does take basic knowledge of the C# language. Making a game is possible with little to no knowledge and we are always willing to help in the discord, but everything goes a lot smoother if you have previous knowledge of how to program.

## Understanding the Forms
### The Grid
When you download this repo you will be given two `.sln` projects. One is `GrumpEngine.sln` and the other is `GrumpMapEditor.sln`. The first project to take a look at is the MapEditor. Inside this project is where you will be creating the map and populating the map with the entities you create. When launching the project a new form will pop up with a 5x5 grid, buttons on the top right corner, and a console output log on the bottom right. To use the 5x5 you first select on which square you want to populate with entities. A new form will open which will give you the option to add entities you have coded to that square. Each square starts out with a value of `0` indicating that the player cannot move onto that square. Once entities have been populated you can save the square and a `1` will appear on the box you have just edited.

### The Controls
If you want the map to be bigger or smaller you can use the buttons at the top right to expand or contract the map by adding (rows/columns) or removing them. Once you are done populating your map and you are happy with your product, you can create a new folder anywhere you like and save your map into it using the `.gmf` exstention. keep in mind that if you create multiple maps and you will want to save all of them into that same maps folder you created initially. 

![alt text](https://i.gyazo.com/fdb943d20791d91836bcd03c144e3c43.png)

**IMPORTANT Removed rows or columns start at the *bottom right* going up verticaly and horizontaly. If you want to make sure that you don't lose any data then first figure out how big you want your map before populating.**

### The Console
The console outputs lots of helpful information about what is happening with the map you are currently creating. Make sure you keep an eye on it because it will tell you if you have saved a square correctly, missing files, or if something has gone horribly wrong in general. If you don't see it in console then there is a good chance something might has gone wrong.

## Creating Entites
This class is included with the repo but we will go over it more in depth here.
```C#
public class EntityTemplate : Entity
    {
        const int type = -1; //TODO: change this value to any number that does not match any already existing entity.
        const float weight = 7.5f; //TODO: change this value to any number that corresponds to the weight you want. End this value with an f.
        string identifier = "#3AB"; //TODO: change this value to a unique hex identifer mark.

        //TODO: add your code here.

        //Returns the type of the entity created
        public int GetEntType()
        {
            return type;
        }

        //Retuns the weight of the entity created.
        public float GetWeight()
        {
            return weight;
        }

        public string GetIdentifier()
        {
            return identifier + " " + type + " " + weight; //TODO: add any other parameters needed to construct this entity
        }
    }
```
## Sharing the Project

# Terms of Service
Anyone is able to use this code freely; however, credit must be shown and sharing this project as your own is prohibited.
