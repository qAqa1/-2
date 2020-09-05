using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МПВУИБ_лаба_2
{
    class SecurityModel
    {
        private List<CecurityCriterion> safeCriterions = new List<CecurityCriterion>();

        SecurityModel() { }

        public void Add(CecurityCriterion saveClass) => safeCriterions.Add(saveClass);

        public static SecurityModel FromFile(string Filename)
        {
            SecurityModel securityModel = new SecurityModel();

            string[] lines = File.ReadAllLines(Filename, Encoding.Default);

            Array.ForEach(lines, line => securityModel.Add(CecurityCriterion.Parse(line)));

            return securityModel;
        }

        public string DebugDesription
        {
            get
            {
                StringBuilder sb = new StringBuilder(string.Empty);

                string border = Environment.NewLine;

                safeCriterions.ForEach(cecurityCriterion =>
                sb.Append(cecurityCriterion.DebugDescription + border));

                return sb.ToString();
            }
        }

        private CecurityCriterion FindById(int Id)
        {
            foreach (CecurityCriterion cecurityCriterion in safeCriterions)
            {
                if (cecurityCriterion.Id == Id)
                {
                    return cecurityCriterion;
                }
            }

            return null;
        }

        public CecurityCriterion this[int Id]
        {
            get => FindById(Id);
        }

        public string ExpertResult()
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            string border = Environment.NewLine;

            int passedTests = 0;

            safeCriterions.ForEach(cecurityCriterion =>
            {
                if (cecurityCriterion.Test())
                {
                    passedTests++;
                }
                else
                {
                    sb.Append(cecurityCriterion.ExpertResult() + border);
                }
            }
            );

            float safePerCent = (float)passedTests / (float)safeCriterions.Count * 100f;

            sb.Append("Система защищена на " + safePerCent + "%");

            return sb.ToString();

        }

        public int Lenght => safeCriterions.Count;
    }
}
