using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МПВУИБ_лаба_2
{
    class Statement
    {
        public readonly string Text;

        public readonly int SaveClass,
                            CecurityCriterionId;

        public Statement(int CecurityCriterionId, string Text, int SaveClass)
        {
            this.CecurityCriterionId = CecurityCriterionId;
            this.Text = Text;
            this.SaveClass = SaveClass;
        }

        public const char border = '|';

        public static Statement Create(int CecurityCriterionId, int SaveClass, string Text) => new Statement(CecurityCriterionId, Text, SaveClass);

        public static Statement Parse(string parseText)
        {
            string[] apart = parseText.Split(border);

            if(apart.Length != 3)
            {
                Console.WriteLine(parseText);
                throw new Exception();
            }

            return Create(apart[0].ToInt(), apart[1].ToInt(), apart[2]);
        }
    }
}
