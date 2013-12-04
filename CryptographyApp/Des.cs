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

        private char[] keyPermutation<char[],char[]>(string initSeq)
        {
            char[] Key1 = new char[12];
            char[] Key2 = new char[12];
            char[] pc1Seq = new char[14];
            char[] leftPart = new char[7];
            char[] rightPart = new char[7];
            char[] proKey = new char[14];
            int[] permOrdr1 = new int[14] { 10, 14, 3, 12, 6, 8, 2, 1, 4, 13, 5, 9, 11, 0 };
            int[] permOrdr2 = new int[12] { 5, 10, 3, 7, 12, 2, 11, 4, 0, 9, 1, 8 };

            //performs the first permutation of the key.
            for (int i = 0; i < 14; i++)
                pc1Seq[i] = initSeq.ElementAt<char>(permOrdr1[i]);

            //assign the values in C
            for (int i = 0; i < 7; i++)
                leftPart[i] = pc1Seq[i];

            //assign the values in D
            for (int i = 0; i < 7; i++)
                rightPart[i] = pc1Seq[i + 7];

            rightPart = LeftShift(rightPart);
            proKey = LeftShift(leftPart);

            for (int i = 0; i < 7; i++)
                proKey[i + 7] = rightPart[i];

            for (int i = 0; i < 12; i++)
                Key1[i] = proKey.ElementAt<char>(permOrdr2[i]);

            rightPart = LeftShift(rightPart);
            proKey = LeftShift(LeftShift(leftPart));

            for (int i = 0; i < 7; i++)
                proKey[i + 7] = rightPart[i];

            for (int i = 0; i < 12; i++)
                Key2[i] = proKey.ElementAt<char>(permOrdr2[i]);
        }

        private char[] LeftShift(char[] bits)
        {
            char a = bits[0];
            char b = bits[1];
            for (int i = 0, j = bits.Count(); i < j; i++)
            {
                if (i < j - 2)
                    bits[i] = bits[i + 2];
                else if (i == j - 2)
                    bits[i] = a;
                else if (i == j - 1)
                    bits[i] = b;
            }
            return bits;
        }
    }
}
