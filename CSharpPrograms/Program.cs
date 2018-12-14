using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples ex = new Examples();
            //ex.RemoveDuplicateChars("nayab");
            //ex.FindSecondHighestNum(5412879);
            //ex.FindDistincsinArray();
            //ex.FindcharInString();
            ex.ReverseStringRemoveDups();
            Console.ReadLine();
        }
    }
    public class Examples
    {
        public void RemoveDuplicateChars(string Name)
        {
            string txt = "";
            foreach (char a in Name)
            {
                if (txt.IndexOf(a) == -1)
                {
                    txt += a;
                }
            }
            Console.WriteLine(txt);
        }
        public void FindSecondHighestNum(int num)
        {
            int rem = 0, val = 0, sval = 0,n=num;
            while (num > 0)
            {
                rem = num % 10;
                if (rem > val)
                {
                    sval = val;
                    val = rem;

                }
                else if (sval < rem)
                    sval = rem;
                
                num = num / 10;
            }
            Console.WriteLine("Number : " + n);
            Console.WriteLine("Highest Number : " + val);
            Console.WriteLine("2nd Highest Number:" + sval);

        }

        public void FindDistincsinArray()
        {
            int[] num = {6, 10, 5, 4, 9, 120,4, 6, 10};
            for (int i=0;i<num.Length;i++)
            {
                int j;
                for(j=0;j<i;j++)
                {
                    if (num[i] == num[j])
                        break;
                }
                if (i == j)
                    Console.Write(num[i] + " ");
            }
        }

        public void FindcharInString()
        {
            String str = "This is Hyderabad City form your name is nayab";
            Console.WriteLine(str.IndexOf("aya"));
        }

        public void ReverseStringRemoveDups()
        {
            string name = "SHAIKNAYAB";
            string NewName = "";
            for(int i=name.Length-1;i>=0;i--)
            {
                if(NewName.IndexOf(name[i])==-1)
                {
                    NewName += name[i];
                }

            }
            Console.WriteLine(NewName);
        }
    }
}
