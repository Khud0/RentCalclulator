using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Calculator
{
    class TextMethods
    {

        // Turns a string into a format of a name (First letter is upper case);
        public static string ToName(string oldName)
        {
            string newName = "";
            int charCount = oldName.Length;
            
            // Avoid bugs
            if (charCount < 1) return "";
            
            // Turn the first letter into the upper case;
            newName += oldName[0].ToString().ToUpper();

            // Turn all the other letters into lower case; 
            // Starts from 1 because we have already added the first char;
            for(int i=1; i<charCount; i++)
            {
                newName += oldName[i].ToString().ToLower();
            }          

            return newName; 
        }

        public static void SetPointer(TextBox tb)
        {
            tb.SelectionStart = tb.Text.Length;
            tb.SelectionLength = 0;
        }

    }
}
