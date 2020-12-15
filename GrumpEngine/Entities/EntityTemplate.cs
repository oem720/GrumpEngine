using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
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
}
