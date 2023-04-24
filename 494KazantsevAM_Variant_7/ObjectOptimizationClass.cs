using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _494KazantsevAM_Variant_7
{
    class ObjectOptimizationClass
    {
        public ObjectOptimizationClass(){
            Setobjectoptimization(this.objectoptimization);
        }
        public ObjectOptimizationClass(string objectoptimization)
        {
            Setobjectoptimization(this.objectoptimization);
        }
        public enum AccountSigns
        {
            NotAccountSigns = -1,
            Equally = 0,
            Plus = 1,
            Minus = 2,
            Multiply = 3,
            Share = 4,
            Degree = 5,
            LeftBracket = 6,
            RightBracket = 7
        }
        string objectoptimization = "V = a * G * ( T1 ^ 2 + b * T2 - u * delP1 ) ^ N + q * ( b1 * T1 + T2 ^ 2 - u1 * delP2 ) ^ N"; // variant 7

        double[] valuesvariables = new double[0];
        List<string> namevaluesvariables = new List<string>();
        //bool flagstandartvalue = true;
        public double? GetRezult()
        {
            string tempString = "";
            for (int i = 4; i < objectoptimization.Length; i++)
            {
                if (AccountSingsChar(objectoptimization[i]) == ' ')
                    i++;
                if ((AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.NotAccountSigns)) && (AccountSingsChar(objectoptimization[i]) != ' '))
                {
                    string tempnamenewvariable = "";
                    while (objectoptimization[i] != ' ')
                    {
                        tempnamenewvariable = tempnamenewvariable + objectoptimization[i];
                        if (i + 1 < objectoptimization.Length)
                            i++;
                        else
                            break;
                    }
                    if (i + 1 < objectoptimization.Length) {
                        if (objectoptimization[i+1] == '^')
                        {
                            int j = i + 3;
                            string tempnamenewvariable2 = "";
                            while (objectoptimization[j] != ' ')
                            {
                                tempnamenewvariable2 = tempnamenewvariable2 + objectoptimization[j];
                                if (j + 1 < objectoptimization.Length)
                                    j++;
                                else
                                    break;
                            }
                            if (!Double.TryParse(tempnamenewvariable, out double tempnum2))
                            {
                                if (tempnamenewvariable == "")
                                {
                                    int k;
                                    string newtempstr = "";
                                    for (k = tempString.Length-1; k > -1; k--)
                                        if (tempString[k] == '(')
                                            break;
                                    for (int p = k + 1; p < tempString.Length; p++)
                                        if (tempString[p] != ')')
                                            tempnamenewvariable = tempnamenewvariable + tempString[p];
                                    tempnamenewvariable = CommaToDotInSTR(tempnamenewvariable);
                                    tempnamenewvariable = Convert.ToDouble(value: new DataTable().Compute(CreateStringFunctionValueVariable(tempnamenewvariable), "")).ToString();
                                    for (int p = 0; p < k; p++)
                                        newtempstr = newtempstr + tempString[p];
                                    if (!Double.TryParse(tempnamenewvariable2, out tempnum2))
                                        tempString = newtempstr + Math.Pow(Convert.ToDouble(tempnamenewvariable), GetValueVariableByName(tempnamenewvariable2).Value);
                                    else
                                        tempString = newtempstr + Math.Pow(Convert.ToDouble(tempnamenewvariable), Convert.ToDouble(tempnamenewvariable2));
                                }
                                else if (!Double.TryParse(tempnamenewvariable2, out tempnum2))
                                    tempString = tempString + Math.Pow(GetValueVariableByName(tempnamenewvariable).Value, GetValueVariableByName(tempnamenewvariable2).Value);
                                else
                                    tempString = tempString + Math.Pow(GetValueVariableByName(tempnamenewvariable).Value, Convert.ToDouble(tempnamenewvariable2));
                            }
                            else
                            {
                                if (!Double.TryParse(tempnamenewvariable2, out tempnum2))
                                    tempString = tempString + Math.Pow(Convert.ToDouble(tempnamenewvariable), GetValueVariableByName(tempnamenewvariable2).Value);
                                else
                                    tempString = tempString + Math.Pow(Convert.ToDouble(tempnamenewvariable), Convert.ToDouble(tempnamenewvariable2));
                            }
                            i = j;
                            continue;
                        }
                    }
                    if (!Double.TryParse(tempnamenewvariable, out double tempnum))
                        tempString = tempString + GetValueVariableByName(tempnamenewvariable).ToString();
                    else
                        tempString = tempString + tempnamenewvariable;
                }
                else
                    tempString = tempString + objectoptimization[i];
            }
            return Convert.ToDouble(new DataTable().Compute(CommaToDotInSTR(tempString), ""));
        }
        private string CreateStringFunctionValueVariable(string stringfunction)
        {
            string tempstr = "";
            for (int i = 0; i < stringfunction.Length; i++)
            {
                if (AccountSingsChar(stringfunction[i]) == ' ')
                    i++;
                if ((AccountSingsChar(stringfunction[i]) == ((int)AccountSigns.NotAccountSigns)) && (AccountSingsChar(stringfunction[i]) != ' '))
                {
                    string tempnamenewvariable = "";
                    while (stringfunction[i] != ' ')
                    {
                        tempnamenewvariable = tempnamenewvariable + stringfunction[i];
                        if (i + 1 < stringfunction.Length)
                            i++;
                        else
                            break;
                    }
                    if (!Double.TryParse(tempnamenewvariable, out double tempnum2))
                        tempstr = tempstr + GetValueVariableByName(tempnamenewvariable);
                    else
                        tempstr = tempstr + tempnamenewvariable;

                }
                else
                    tempstr = tempstr + stringfunction[i];
            }
            return stringfunction;
        }
        public bool ExistVariableByName(string namevar)
        {
            for (int i = 0; i < GetNumberVariable(); i++)
                if (namevar == GetNameVariable(i))
                    return true;
            return false;
        }
        private void Setnumbervariable()
        {
            Array.Resize(ref valuesvariables, namevaluesvariables.Count);
            for (int i = 0; i < valuesvariables.Length; i++)
                valuesvariables[i] = 1;
        }
        private string CommaToDotInSTR(string str)
        {
            string tempstr = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                    tempstr += ".";
                else
                    tempstr += str[i];
            }
            return tempstr;
        }
        public string Getobjectoptimization(bool flagWhitespace)
        {
            if (flagWhitespace)
                return objectoptimization;
            string tobjectoprimization = "";
            for (int i = 0; i < objectoptimization.Length; i++)
                if (objectoptimization[i] != ' ')
                    tobjectoprimization += objectoptimization[i];
            return tobjectoprimization;
        }
        private int AccountSingsChar(char ch)
        {
            switch (ch)
            {
                case '=':
                    return ((int)AccountSigns.Equally);
                case '+':
                    return ((int)AccountSigns.Plus);
                case '-':
                    return ((int)AccountSigns.Equally);
                case '*':
                    return ((int)AccountSigns.Multiply);
                case '/':
                    return ((int)AccountSigns.Share);
                case '^':
                    return ((int)AccountSigns.Degree);
                case '(':
                    return ((int)AccountSigns.LeftBracket);
                case ')':
                    return ((int)AccountSigns.RightBracket);
                default:
                    return ((int)AccountSigns.NotAccountSigns);
            }
        }
        public bool Setobjectoptimization(string objectoptimization)
        {
            bool flagnoterror = false, flagsignorvariable = false;
            int levelbricket = 0;
            List<string> tempnamevaluesvariables = new List<string>();
            string tempnamenewvariable = "";
            if (objectoptimization.Length > 3) { 
                if (objectoptimization[2] == '=')
                {
                    for (int i = 4; i < objectoptimization.Length; i++)
                    {
                        if (flagsignorvariable)
                        {
                            if ((objectoptimization[i] != ' ') && (AccountSingsChar(objectoptimization[i]) != ((int)AccountSigns.NotAccountSigns)))
                            {
                                flagsignorvariable = false;
                                if (i + 1 < objectoptimization.Length)
                                {
                                    if (AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.RightBracket))
                                    {
                                        flagsignorvariable = true;
                                        levelbricket--;
                                    }
                                    else if (AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.LeftBracket))
                                        levelbricket++;
                                    i++;
                                }
                                else {
                                    if (AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.RightBracket))
                                        levelbricket--;
                                    if ((i + 1 == objectoptimization.Length) && (levelbricket == 0) && (AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.RightBracket)))
                                        flagnoterror = true;
                                    else
                                        break;
                                }
                            }
                            else
                                break;
                        }
                        else
                        {
                            if ((objectoptimization[i] != ' ') && (AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.NotAccountSigns)))
                            {
                                flagsignorvariable = true;
                                tempnamenewvariable = "";
                                while (objectoptimization[i] != ' ')
                                {
                                    tempnamenewvariable = tempnamenewvariable + objectoptimization[i];
                                    if (i + 1 < objectoptimization.Length)
                                        i++;
                                    else
                                        break;
                                }
                                if ((tempnamenewvariable != "") && (!double.TryParse(tempnamenewvariable, out double trez)))
                                {
                                    if (tempnamevaluesvariables.Count > 0)
                                    {
                                        bool namevariableloop = false;
                                        foreach (string tempnamevaluesvariable in tempnamevaluesvariables)
                                            if ((tempnamevaluesvariable == tempnamenewvariable) || (double.TryParse(tempnamenewvariable, out double tt)))
                                                namevariableloop = true;
                                        if (!namevariableloop)
                                            tempnamevaluesvariables.Add(tempnamenewvariable);
                                    }
                                    else if (!double.TryParse(tempnamenewvariable, out double tempt))
                                        tempnamevaluesvariables.Add(tempnamenewvariable);
                                    if ((i + 1 == objectoptimization.Length) && levelbricket == 0)
                                        flagnoterror = true;
                                }
                                else if (double.TryParse(tempnamenewvariable, out trez))
                                {
                                    if ((i + 1 == objectoptimization.Length) && (levelbricket == 0)) {
                                        flagnoterror = true;
                                        break;
                                    }

                                    continue;
                                }
                                else
                                    break;
                            }
                            else
                            {
                                flagsignorvariable = false;
                                if (i + 1 < objectoptimization.Length)
                                {
                                    if (AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.RightBracket))
                                        levelbricket--;
                                    else if (AccountSingsChar(objectoptimization[i]) == ((int)AccountSigns.LeftBracket))
                                        levelbricket++;
                                    else
                                        break;
                                    i++;
                                }
                            }
                        }
                    }
                    if (flagnoterror)
                    {
                        namevaluesvariables = tempnamevaluesvariables;
                        this.objectoptimization = objectoptimization;
                        Setnumbervariable();
                    }
                } 
            }
            return flagnoterror;
        }
        public bool SetValueVariableByName(string namevariable, double newvalue)
        {
            bool flagnoterror = false;
            if (valuesvariables.Length>0) {
                int i = 0;
                foreach (string namevaluesvariable in namevaluesvariables)
                {
                    if (namevariable == namevaluesvariable)
                    {
                        valuesvariables[i] = newvalue;
                        flagnoterror = true;
                        break;
                    }
                    i++;
                }
            }
            return flagnoterror;
        }
        public bool SetValueVariableByNomber(int numberofvariable, double newvalue)
        {
            bool flagnoterror = false;
            if ((valuesvariables.Length > 0) && (numberofvariable >= 0) && (numberofvariable < valuesvariables.Length))
            {
                valuesvariables[numberofvariable] = newvalue;
                flagnoterror = true;
            }
            return flagnoterror;
        }
        public double? GetValueVariableByName(string namevariable)
        {
            double? value = null;
            if (valuesvariables.Length > 0)
            {
                int i = 0;
                foreach (string namevaluesvariable in namevaluesvariables)
                {
                    if (namevariable == namevaluesvariable)
                    {
                        value = valuesvariables[i];
                        break;
                    }
                    i++;
                }
            }
            return value;
        }
        public double? GetValueVariableByNomber(int numberofvariable)
        {
            double? value = null;
            if ((valuesvariables.Length > 0) && (numberofvariable >= 0) && (numberofvariable < valuesvariables.Length))
                value = valuesvariables[numberofvariable];
            return value;
        }
        public string GetNameVariable(int numberofvariable)
        {
            string value = "";
            if ((valuesvariables.Length > 0) && (numberofvariable >= 0) && (numberofvariable < valuesvariables.Length))
                value = value + namevaluesvariables[numberofvariable];
            return value;
        }
        public int GetNumberVariable() { return namevaluesvariables.Count; }

        public double? GetDerivativeFunction(string namevariable, int numberderivative)
        {
            double? rezderivativefunction = null;
            const double dval = 1e-10;
            if (GetValueVariableByName(namevariable) != null)
            {
                double tempVar = GetValueVariableByName(namevariable).Value, tempRez;
                SetValueVariableByName(namevariable, tempVar + dval);
                tempRez = GetRezult().Value;
                SetValueVariableByName(namevariable, tempVar - dval);
                rezderivativefunction = (tempRez - GetRezult().Value)/(dval * 2); 
            }
            return rezderivativefunction;
        }
    }
}
