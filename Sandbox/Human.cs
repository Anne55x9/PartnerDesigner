using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Human
    {
        maleOrFemale Gender { get; set;}
        eyeColor Eyes { get; set; }
        haircolor Hair { get; set; }
        heightCategory Height { get; set; }

        public enum maleOrFemale {male,female}
        public enum eyeColor {blue, green, brown, satanic}
        public enum haircolor {blonde, brown, black, red}
        public enum heightCategory {VeryShort, Short, MediumHeight, Tall, VeryTall}

        public Human(maleOrFemale Gender,  eyeColor Eyes, haircolor Hair, heightCategory Height)
        {
            this.Gender = Gender;
            this.Eyes = Eyes;
            this.Hair = Hair;
            this.Height = Height;
        }

        public String GetDescription()
        {
            String description = "You got a " + Gender;
            description = description + ", with " + Eyes + " eyes";
            description = description + ", " + Hair + " hair";
            description = description + ", who is " + Height;

            return description;
        }

        //public String GetGenderDescription()
        //{
        //    if (maleOrFemale)
        //    {
        //        return "man";
        //    }
        //    else
        //    {
        //        return "woman";
        //    }
        //}

        //public 
        //{
        //    switch (heightCategory)
        //    {
        //        case VeryShort:
        //            return "Very short";
        //        case Short:
        //            return "Short";
        //        case MediumHeight:
        //            return "Medium height";
        //        case Tall:
        //            return "Tall";
        //        case VeryTall:
        //            return "Very tall";
        //        default:
        //            return "Unknown height";
        //    }
        //}
    }
}
