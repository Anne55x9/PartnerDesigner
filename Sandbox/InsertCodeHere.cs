using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Human h1 = new Human(Human.maleOrFemale.male, Human.eyeColor.blue, Human.haircolor.blonde, Human.heightCategory.MediumHeight);
            Human h2 = new Human(Human.maleOrFemale.female, Human.eyeColor.brown, Human.haircolor.red, Human.heightCategory.Tall);
            Human h3 = new Human(Human.maleOrFemale.female, Human.eyeColor.satanic, Human.haircolor.black, Human.heightCategory.VeryTall);

            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
            Console.WriteLine(h3.GetDescription());




            // The LAST line of code should be ABOVE this line
        }
    }
}
