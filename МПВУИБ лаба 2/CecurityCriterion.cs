using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МПВУИБ_лаба_2
{
    class CecurityCriterion
    {
        public readonly int Id,
                            BorderValue;

        public int Value = 7;


        public readonly string Text,
                               Recomendation;


        public CecurityCriterion(int id, int borderValue, string text, string outputStringIfSmallValue)
        {
            Id = id;
            BorderValue = borderValue;
            Text = text;
            Recomendation = outputStringIfSmallValue;
        }

        public string DebugDescription
        {
            get
            {
                StringBuilder sb = new StringBuilder(string.Empty);

                string border = Environment.NewLine;

                sb.Append("Id = " + Id);
                sb.Append(border);
                sb.Append("BorderValue = " + BorderValue);
                sb.Append(border);
                sb.Append("Value = " + Value);
                sb.Append(border);
                sb.Append("Text = " + Text);
                sb.Append(border);
                sb.Append("OutputStringIfSmallValue = " + Recomendation);
                sb.Append(border);

                return sb.ToString();
            }
        }


        public bool Test() => !(Value > BorderValue);


        public string ExpertResult()
        {
            if (!(Value > BorderValue))
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder(string.Empty);

            sb.Append(Text + ":" + Environment.NewLine);
            sb.Append("    ");
            
            if (Value > BorderValue)
            {
                sb.Append(Recomendation);
            }
            else
            {
                sb.Append("По данному критерию защита удавлетворяет всем требованиям");
            }

            sb.Append(Environment.NewLine);

            return sb.ToString();
        }

        private const char border = '|';

        public static CecurityCriterion Parse(string saveClassStr)
        {
            int id, borderValue;
            string text, outputStringIfSmallValue;


            string[] apart = saveClassStr.Split(border);

            if (apart.Length != 4)
            {
                throw new Exception();
            }

            id = apart[0].ToInt();
            borderValue = apart[1].ToInt();
            text = apart[2];
            outputStringIfSmallValue = apart[3];

            return new CecurityCriterion(id, borderValue, text, outputStringIfSmallValue);
        }

        public static implicit operator string(CecurityCriterion saveClass) => saveClass.Text;
    }
}

