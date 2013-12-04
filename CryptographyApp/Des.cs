using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyApp
{
    class Des
    {
        char binKey;
        char binText;
        string finalSeq;

        public Des (char bKey, char bText)
        {
            this.binKey = bKey;
            this.binText = bText;
        }        
            
        private char Key(string originalKey, out char Key1, out char Key2)
        {
            if (originalKey.ElementAt<char>(7) != originalKey.ElementAt<char>(15))
                
            else
            {

            }
        }

        private char keyPermutation(string initSeq)
        {
            char[] pc1Seq = new char[14];
            char[] leftPart = new char[7];
            char[] rightPart = new char[7];
            int[] permOrdr1 = new int[14] { 11, 15, 4, 13, 7, 9, 3, 2, 5, 14, 6, 10, 12, 1 };

            //performs the first permutation of the key.
            for (int i = 0; i < 14; i++)
                pc1Seq[i] = initSeq.ElementAt<char>(permOrdr1[i]);

            //assign the values in C
            for (int i = 0; i < 7; i++)
                leftPart[i] = pc1Seq[i];

            //assign the values in D
            for (int i = 0; i < 7; i++)
                rightPart[i] = pc1Seq[i + 7];
        }
    }
}
