using System;
using System.Collections.Generic;

namespace _494KazantsevAM_Variant_7
{
    class MethodSearchExtremumClass
    {
        ObjectOptimizationClass mainfunction, secondRestructions;
        string[] namevariable = new string[0];
        double[] leftboardvariable = new double[0], rightboardvariable = new double[0];
        double maxminsecondRestr;
        int flagsinssecondRest = -2;
        double accuracy = 0.1;
        bool flagminmaxextremum = false;
        public MethodSearchExtremumClass() { }
        public MethodSearchExtremumClass(ObjectOptimizationClass mainfunction,
            ObjectOptimizationClass secondRestructions, double maxminsecondRestr, double accuracy,
            int flagsinssecondRest, bool flagminmaxextremum)
        {
            SetMainFunction(mainfunction, secondRestructions, maxminsecondRestr, accuracy, flagsinssecondRest, flagminmaxextremum);
        }
        // Сетеры и гетеры переменных
        public void SetAccuracy(double accuracy)
        {
            this.accuracy = accuracy;
        }
        public void SetMainFunction(ObjectOptimizationClass mainfunction, ObjectOptimizationClass secondRestructions, double maxminsecondRestr, double accuracy, int flagsinssecondRest, bool flagminmaxextremum)
        {
            this.mainfunction = mainfunction;
            this.secondRestructions = secondRestructions;
            this.maxminsecondRestr = maxminsecondRestr;
            this.flagsinssecondRest = flagsinssecondRest;
            this.accuracy = accuracy;
            this.flagminmaxextremum = flagminmaxextremum;
        }
        public void SetNumberVariable(int countVariable)
        {
            if (countVariable > 0)
            {
                Array.Resize(ref namevariable, countVariable);
                Array.Resize(ref leftboardvariable, countVariable);
                Array.Resize(ref rightboardvariable, countVariable);
            }
        }
        public void SetFlagMinMax(bool flagminmax) {
            this.flagminmaxextremum = flagminmax;
        }
        public bool SetValueVariable(double leftboard, double rightboard, string namevar, int numofvar)
        {
            bool flag = false;
            if((numofvar >= 0) && (numofvar < namevariable.Length))
            {
                leftboardvariable[numofvar] = leftboard;
                rightboardvariable[numofvar] = rightboard;
                namevariable[numofvar] = namevar;
                flag = true;
            }
            return flag;
        }

        // Методы поиска экстремума
        // Метод полного перебора с постоянным шагом (работает)
        public double[] MethodAllValuesFunction(RezultCalculateForm calculateForm)
        {
            string[] parames = new string[namevariable.Length + 1];
            double[] minmax = new double[namevariable.Length + 1];
            calculateForm.ClearRezultMethodTable();
            if (!flagminmaxextremum)
                minmax[namevariable.Length] = double.MaxValue;
            else
                minmax[namevariable.Length] = double.MinValue;
            RecursiveHelpWithMethodAllValuesFunction(ref parames, ref minmax, 0);
            return minmax;
        }
        private void RecursiveHelpWithMethodAllValuesFunction(ref string[] parames, ref double[] minmax, int numbervalue)
        {
            if (numbervalue == namevariable.Length)
            {
                for (int i = 0; i < namevariable.Length; i++)
                {
                    mainfunction.SetValueVariableByName(namevariable[i], double.Parse(parames[i]));
                    secondRestructions.SetValueVariableByName(namevariable[i], double.Parse(parames[i]));
                }
                parames[namevariable.Length] = Math.Round((double)mainfunction.GetRezult(), GetRoundingBit(accuracy)).ToString();
                if (CheckingForEntryIntoRestriction(2))
                {
                    if (CheckingTheNewValueFunction(minmax[namevariable.Length]))
                    {
                        for (int i = 0; i < namevariable.Length; i++)
                            minmax[i] = Math.Round(double.Parse(parames[i]), GetRoundingBit(accuracy));
                        minmax[namevariable.Length] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy));
                    }
                    //calculateForm.AddNewRowRezultMethodTable(parames);
                }
            }
            else
            {
                for (double X = leftboardvariable[numbervalue]; X <= rightboardvariable[numbervalue]; X += accuracy)
                {
                    parames[numbervalue] = Math.Round(X, GetRoundingBit(accuracy)).ToString();
                    RecursiveHelpWithMethodAllValuesFunction(ref parames, ref minmax, (numbervalue + 1));
                }
            }
        }
        // Метод полного перебора с переменным шагом (работает)
        public double[] MethodAllValuesUpdateStepFunction(RezultCalculateForm calculateForm)
        {
            string[] parames = new string[namevariable.Length + 1];
            double[] minmax = new double[namevariable.Length + 1];
            double[] a = new double[namevariable.Length];
            double[] b = new double[namevariable.Length];
            calculateForm.ClearRezultMethodTable();
            for (int i = 0; i < 2; i++)
            {
                a[i] = leftboardvariable[i];
                b[i] = rightboardvariable[i];
            }
            if (!flagminmaxextremum)
                minmax[namevariable.Length] = double.MaxValue;
            else
                minmax[namevariable.Length] = double.MinValue;
            RecursiveMethodAllValuesUpdateStepFunction(calculateForm, ref parames, ref minmax, ref a, ref b, 1);
            for (int i = 0; i < minmax.Length; i++)
                minmax[i] = Math.Round(minmax[i], GetRoundingBit(accuracy));
            return minmax;
        }
        private void RecursiveMethodAllValuesUpdateStepFunction(RezultCalculateForm calculateForm, ref string[] parames, ref double[] minmax, ref double[] a, ref double[] b, double step)
        {
            Func<double, int, double> newb = (tempb, indx) => {
                if (tempb + step > rightboardvariable[indx])
                    return rightboardvariable[indx];
                else
                    return tempb + step;
                };
            Func<double, int, double> newa = (tempa, indx) => {
                if (tempa - step < leftboardvariable[indx])
                    return leftboardvariable[indx];
                else
                    return tempa - step;
            };
            if (step >= accuracy)
            {
                bool flag = true;
                for(double i = a[0]; i <= b[0]; i += step)
                {
                    for(double j = a[1]; j <= b[1]; j += step)
                    {
                        secondRestructions.SetValueVariableByNomber(0, i);
                        secondRestructions.SetValueVariableByNomber(1, j);
                        if (CheckingForEntryIntoRestriction(2))
                        {
                            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), i);
                            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), j);
                            if (flag)
                            {
                                minmax[0] = i;
                                minmax[1] = j;
                                minmax[2] = mainfunction.GetRezult().Value;
                                flag = false;
                            }
                            else if (CheckingTheNewValueFunction(minmax[2]))
                            {
                                minmax[0] = i;
                                minmax[1] = j;
                                minmax[2] = mainfunction.GetRezult().Value;
                            }
                            for (int temptablei = 0; temptablei < parames.Length - 1; temptablei++)
                                parames[temptablei] = mainfunction.GetValueVariableByName(secondRestructions.GetNameVariable(temptablei)).ToString();
                            parames[parames.Length - 1] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy)).ToString();
                            calculateForm.AddNewRowRezultMethodTable(parames);
                        }
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    a[i] = newa(minmax[i], i);
                    b[i] = newb(minmax[i], i);
                }
                step /= 10;
                RecursiveMethodAllValuesUpdateStepFunction(calculateForm, ref parames, ref minmax, ref a, ref b, step);
            }
        }
        // Комплекс-метод Бокса (работает)
        public double[] ComplexMethodBoxing(RezultCalculateForm calculateForm)
        {
            string[] parames = new string[namevariable.Length + 1];
            double[] minmax = new double[namevariable.Length + 1];
            calculateForm.ClearRezultMethodTable();
            if (!flagminmaxextremum)
                minmax[namevariable.Length] = double.MaxValue;
            else
                minmax[namevariable.Length] = double.MinValue;
            Func<int, int> nvertexes = (n) => {
                if (n <= 5)
                    return 2 * n;
                else
                    return n;
            };
            double[,] x = new double[secondRestructions.GetNumberVariable(), nvertexes(secondRestructions.GetNumberVariable())];
            var rand = new Random();
            int p = 0;
            bool[] compliancewithrestrictions = new bool[nvertexes(secondRestructions.GetNumberVariable())];
            while (true)
            {
                for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                {
                    for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
                    {
                        double temorand = rand.NextDouble();
                        x[i, j] = leftboardvariable[i] + temorand * (rightboardvariable[i] - leftboardvariable[i]);
                    }
                }
                p = 0;
                for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
                {
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                        secondRestructions.SetValueVariableByNomber(i, x[i, j]);
                    if (CheckingForEntryIntoRestriction(2))
                    {
                        p++;
                        compliancewithrestrictions[j] = true;
                    }
                    else
                        compliancewithrestrictions[j] = false;
                }
                if (p > 0)
                    break;
            }
            for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
            {
                if (compliancewithrestrictions[j])
                    continue;
                for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    secondRestructions.SetValueVariableByNomber(i, x[i, j]);
                while (!CheckingForEntryIntoRestriction(2))
                {
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    {
                        double tempsum = 0;
                        for (int k = 0, t = 0; k < p && k + t < nvertexes(secondRestructions.GetNumberVariable()); k++)
                        {
                            if (!compliancewithrestrictions[k + t])
                            {
                                t++;
                                k--;
                                continue;
                            }
                            tempsum += x[i, k + t];
                        }
                        x[i, j] = ( x[i, j] + tempsum / p ) / 2;
                        secondRestructions.SetValueVariableByNomber(i, x[i, j]);
                    }
                    if (CheckingForEntryIntoRestriction(2))
                    {
                        p++;
                        compliancewithrestrictions[j] = true;
                    }
                }
                    
            }

            for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
            {
                for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(i), x[i, j]);
                for (int temptablei = 0; temptablei < parames.Length - 1; temptablei++)
                    parames[temptablei] = mainfunction.GetValueVariableByName(secondRestructions.GetNameVariable(temptablei)).ToString();
                parames[parames.Length - 1] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy)).ToString();
                calculateForm.AddNewRowRezultMethodTable(parames);
            }
            double[] F = new double[nvertexes(secondRestructions.GetNumberVariable())];
            bool flagstop = false;
            int[] minmaxindx = new int[2];
            double[] c = new double[secondRestructions.GetNumberVariable()];
            double b = 0;
            for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
            {
                for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(i), x[i, j]);
                F[j] = mainfunction.GetRezult().Value;
            }
            while (!flagstop)
            {
                for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
                {
                    if (j == 0)
                    {
                        minmaxindx[0] = j;
                        minmaxindx[1] = j;
                    }
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    {
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(i), x[i, j % secondRestructions.GetNumberVariable()]);
                    }
                    if ((flagminmaxextremum && F[j] >= F[minmaxindx[0]]) || (!flagminmaxextremum && F[j] <= F[minmaxindx[0]]))
                        minmaxindx[0] = j;
                    else if ((flagminmaxextremum && F[j] <= F[minmaxindx[1]]) || (!flagminmaxextremum && F[j] >= F[minmaxindx[1]]))
                        minmaxindx[1] = j;
                }
                for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                {
                    double tempsum = 0;
                    for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
                        tempsum += x[i, j];
                    tempsum -= x[i, minmaxindx[1]];
                    c[i] = tempsum / (nvertexes(secondRestructions.GetNumberVariable()) - 1);
                }
                for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    b += Math.Abs(c[i] - x[i, minmaxindx[1]]) + Math.Abs(c[i] - x[i, minmaxindx[0]]);
                b /= 2 * secondRestructions.GetNumberVariable();
                if (b < accuracy)
                {
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                        minmax[i] = x[i, minmaxindx[0]];
                    minmax[secondRestructions.GetNumberVariable()] = F[minmaxindx[0]];
                    flagstop = true;
                }
                else
                {
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    {
                        x[i, minmaxindx[1]] = 2.3 * c[i] - 1.3 * x[i, minmaxindx[1]];
                        if (x[i, minmaxindx[1]] > rightboardvariable[i])
                            x[i, minmaxindx[1]] = rightboardvariable[i];
                        if (x[i, minmaxindx[1]] < leftboardvariable[i])
                            x[i, minmaxindx[1]] = leftboardvariable[i];
                        secondRestructions.SetValueVariableByNomber(i, x[i, minmaxindx[1]]);
                    }
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                    {
                        while (!CheckingForEntryIntoRestriction(2))
                        {
                            x[i, minmaxindx[1]] = (x[i, minmaxindx[1]] + c[i]) / 2;
                            if (x[i, minmaxindx[1]] > rightboardvariable[i])
                                x[i, minmaxindx[1]] = rightboardvariable[i];
                            if (x[i, minmaxindx[1]] < leftboardvariable[i])
                                x[i, minmaxindx[1]] = leftboardvariable[i];
                            secondRestructions.SetValueVariableByNomber(i, x[i, minmaxindx[1]]);
                            if (x[i, minmaxindx[1]] - c[i] < accuracy)
                                break;
                            }
                        
                    }
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(i), x[i, minmaxindx[1]]);
                    while ((flagminmaxextremum && F[minmaxindx[1]] > mainfunction.GetRezult().Value) ||
                        (!flagminmaxextremum && F[minmaxindx[1]] < mainfunction.GetRezult().Value))
                    {
                        for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                        {
                                x[i, minmaxindx[1]] = (x[i, minmaxindx[1]] + x[i, minmaxindx[0]]) / 2;
                                if (x[i, minmaxindx[1]] > rightboardvariable[i])
                                    x[i, minmaxindx[1]] = rightboardvariable[i];
                                if (x[i, minmaxindx[1]] < leftboardvariable[i])
                                    x[i, minmaxindx[1]] = leftboardvariable[i];
                            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(i), x[i, minmaxindx[1]]);
                        }
                    }
                    F[minmaxindx[1]] = mainfunction.GetRezult().Value;
                }
                for (int j = 0; j < nvertexes(secondRestructions.GetNumberVariable()); j++)
                {
                    for (int i = 0; i < secondRestructions.GetNumberVariable(); i++)
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(i), x[i, j]);
                    for (int temptablei = 0; temptablei < parames.Length - 1; temptablei++)
                        parames[temptablei] = mainfunction.GetValueVariableByName(secondRestructions.GetNameVariable(temptablei)).ToString();
                    parames[parames.Length - 1] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy)).ToString();
                    calculateForm.AddNewRowRezultMethodTable(parames);
                }
            }
            for (int i = 0; i < minmax.Length; i++)
                minmax[i] = Math.Round(minmax[i], GetRoundingBit(accuracy));
            return minmax;
        }
        // Симплекс метод (не реализован)
        /*public double[] SimplexMethod(RezultCalculateForm calculateForm, double alpha)
        {
            string[] parames = new string[namevariable.Length + 1];
            double[] minmax = new double[namevariable.Length + 1];
            double[] del = new double[2];
            del[0] = (Math.Pow(secondRestructions.GetNumberVariable(), 0.5) + secondRestructions.GetNumberVariable() - 1) * alpha / (secondRestructions.GetNumberVariable() * Math.Pow(2, 0.5));
            del[1] = (Math.Pow(secondRestructions.GetNumberVariable(), 0.5) - 1) * alpha / (secondRestructions.GetNumberVariable() * Math.Pow(2, 0.5));
            List<double[]> dot = new List<double[]>();
            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), leftboardvariable[0]);
            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), leftboardvariable[1]);
            dot.Add(new double[3] { leftboardvariable[0], leftboardvariable[1], mainfunction.GetRezult().Value});
            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), leftboardvariable[0] + del[1]);
            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), leftboardvariable[1] + del[0]);
            dot.Add(new double[3] { leftboardvariable[0] + del[1], leftboardvariable[1] + del[0], mainfunction.GetRezult().Value });
            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), leftboardvariable[0] + del[0]);
            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), leftboardvariable[1] + del[1]);
            dot.Add(new double[3] { leftboardvariable[0] + del[0], leftboardvariable[1] + del[1], mainfunction.GetRezult().Value });
            int tempetr;
            if (!flagminmaxextremum)
            {
                if (dot[0][2] <= dot[1][2] && dot[0][2] <= dot[2][2])
                    tempetr = 0;
                else if (dot[0][2] >= dot[1][2] && dot[1][2] <= dot[2][2])
                    tempetr = 1;
                else if (dot[0][2] >= dot[2][2] && dot[1][2] >= dot[2][2])
                    tempetr = 2;
            }
            else
            {
                if (dot[0][2] >= dot[1][2] && dot[0][2] >= dot[2][2])
                    tempetr = 0;
                else if (dot[0][2] <= dot[1][2] && dot[1][2] >= dot[2][2])
                    tempetr = 1;
                else if (dot[0][2] <= dot[2][2] && dot[1][2] <= dot[2][2])
                    tempetr = 2;
            }
            while (true)
            {
                if (flagminmaxextremum)
                {
                    if(dot[0][2] <= dot[1][2] && dot[0][2] <= dot[2][2])
                    {
                        dot[0][0] = dot[1][0] + dot[2][0] - dot[0][0];
                        dot[0][1] = dot[1][1] + dot[2][1] - dot[0][1];
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), dot[0][0]);
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), dot[0][1]);
                        dot[0][2] = mainfunction.GetRezult().Value;
                    }
                    else if(dot[0][2] >= dot[1][2] && dot[1][2] <= dot[2][2])
                    {
                        dot[1][0] = dot[0][0] + dot[2][0] - dot[1][0];
                        dot[1][1] = dot[0][1] + dot[2][1] - dot[1][1];
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), dot[1][0]);
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), dot[1][1]);
                        dot[1][2] = mainfunction.GetRezult().Value;
                    }
                    else if (dot[0][2] >= dot[2][2] && dot[1][2] >= dot[2][2])
                    {
                        dot[2][0] = dot[0][0] + dot[1][0] - dot[2][0];
                        dot[2][1] = dot[0][1] + dot[1][1] - dot[2][1];
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), dot[2][0]);
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), dot[2][1]);
                        dot[2][2] = mainfunction.GetRezult().Value;
                    }
                }
                else
                {
                    if (dot[0][2] >= dot[1][2] && dot[0][2] >= dot[2][2])
                    {
                        dot[0][0] = dot[1][0] + dot[2][0] - dot[0][0];
                        dot[0][1] = dot[1][1] + dot[2][1] - dot[0][1];
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), dot[0][0]);
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), dot[0][1]);
                        dot[0][2] = mainfunction.GetRezult().Value;
                    }
                    else if (dot[0][2] <= dot[1][2] && dot[1][2] >= dot[2][2])
                    {
                        dot[1][0] = dot[0][0] + dot[2][0] - dot[1][0];
                        dot[1][1] = dot[0][1] + dot[2][1] - dot[1][1];
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), dot[1][0]);
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), dot[1][1]);
                        dot[1][2] = mainfunction.GetRezult().Value;
                    }
                    else if (dot[0][2] <= dot[2][2] && dot[1][2] <= dot[2][2])
                    {
                        dot[2][0] = dot[0][0] + dot[1][0] - dot[2][0];
                        dot[2][1] = dot[0][1] + dot[1][1] - dot[2][1];
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), dot[2][0]);
                        mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), dot[2][1]);
                        dot[2][2] = mainfunction.GetRezult().Value;
                    }// остановиля тут
                }
                
            }
            minmax[namevariable.Length] = flagminmaxextremum ? double.MinValue : double.MaxValue;

            return minmax;
        }*/

        // Метод генетического алгоритма(требуется доработка и исправление ошибок)
        public double[] MethodGeneticAlgorithm(RezultCalculateForm calculateForm)
        {
            string[] parames = new string[namevariable.Length + 1];
            double[] minmax = new double[namevariable.Length + 1];
            calculateForm.ClearRezultMethodTable();
            if (!flagminmaxextremum)
                minmax[namevariable.Length] = double.MaxValue;
            else
                minmax[namevariable.Length] = double.MinValue;
            // Задание изначальных параметров генетического алгоритма
            const int countchromosomes = 4, countgen = 2;
            const int population = 100;
            double[,] chromosomes = new double[countgen, countchromosomes];
            double[,] newpopulationchromosomes = new double[countgen, countchromosomes];
            var rand = new Random();
            // Получение первых 4 хромосом
            while (true)
            {
                bool flagexit = true;
                for (int i = 0; i < countgen; i++)
                {
                    for (int j = 0; j < countchromosomes; j++)
                    {
                        double temorand = rand.NextDouble();
                        chromosomes[i, j] = leftboardvariable[i] + temorand * (rightboardvariable[i] - leftboardvariable[i]);
                        newpopulationchromosomes[i, j] = chromosomes[i, j];
                    }
                }
                for (int i = 0; i < countchromosomes; i++)
                {
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[0, i]);
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), chromosomes[1, i]);
                    if (!CheckingForEntryIntoRestriction(2))
                        flagexit = false;
                }
                if (flagexit)
                    break;
            }

            int numminchromosom, nummaxchromosom;
            for(int numpopulation = 1; numpopulation <= population; numpopulation++)
            {
                // Получение номера лучшей/худшей хромосомы 
                nummaxchromosom = NumberMinMaxChromosomes(chromosomes, false);
                numminchromosom = NumberMinMaxChromosomes(chromosomes, true);

                // Составление нового поколения хромосом
                newpopulationchromosomes[0, 0] = chromosomes[0, nummaxchromosom];
                newpopulationchromosomes[0, 1] = chromosomes[0, nummaxchromosom];
                newpopulationchromosomes[1, 2] = chromosomes[1, nummaxchromosom];
                newpopulationchromosomes[1, 3] = chromosomes[1, nummaxchromosom];

                // Мутация генов
                for (int i = 0; i < countchromosomes; i++)
                {
                    if(i < 2)
                    {

                        while (true)
                        {
                            bool flagexit = true;
                            double temorand = rand.NextDouble();
                            if((newpopulationchromosomes[1, i] + ((population - numpopulation) / population) * temorand * (rightboardvariable[1] - leftboardvariable[1])) <= rightboardvariable[1] && numminchromosom != i)
                                newpopulationchromosomes[1, i] = newpopulationchromosomes[1, i] + ((population - numpopulation) / population) * temorand * (rightboardvariable[1] - leftboardvariable[1]);
                            else if ((newpopulationchromosomes[1, i] - ((population - numpopulation) / population) * temorand * (rightboardvariable[1] - leftboardvariable[1])) >= leftboardvariable[1] && numminchromosom != i)
                                newpopulationchromosomes[1, i] = newpopulationchromosomes[1, i] - ((population - numpopulation) / population) * temorand * (rightboardvariable[1] - leftboardvariable[1]);
                            else
                                newpopulationchromosomes[1, i] = leftboardvariable[1] + ((population - numpopulation) / population) * (rightboardvariable[1] - leftboardvariable[1]);
                            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), newpopulationchromosomes[0, i]);
                            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), newpopulationchromosomes[1, i]);
                            if (!CheckingForEntryIntoRestriction(2))
                                flagexit = false;
                            if (flagexit)
                                break;
                        }

                        //newpopulationchromosomes[1, i] =
                    }
                    else
                    {

                        while (true)
                        {
                            bool flagexit = true;
                            double temorand = rand.NextDouble();
                            if ((newpopulationchromosomes[0, i] + ((population - numpopulation) / population) * temorand * (rightboardvariable[0] - leftboardvariable[0])) <= rightboardvariable[0] && numminchromosom != i)
                                newpopulationchromosomes[0, i] = newpopulationchromosomes[0, i] + ((population - numpopulation) / population) * temorand * (rightboardvariable[0] - leftboardvariable[0]);
                            else if ((newpopulationchromosomes[0, i] - ((population - numpopulation) / population) * temorand * (rightboardvariable[0] - leftboardvariable[0])) >= leftboardvariable[0] && numminchromosom != i)
                                newpopulationchromosomes[0, i] = newpopulationchromosomes[0, i] - ((population - numpopulation) / population) * temorand * (rightboardvariable[0] - leftboardvariable[0]);
                            else
                                newpopulationchromosomes[0, i] = leftboardvariable[0] + ((population - numpopulation) / population) * (rightboardvariable[0] - leftboardvariable[0]);
                            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), newpopulationchromosomes[0, i]);
                            mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(1), newpopulationchromosomes[1, i]);
                            if (!CheckingForEntryIntoRestriction(2))
                                flagexit = false;
                            if (flagexit)
                                break;
                        }

                        //newpopulationchromosomes[0, i] =
                    }
                }

                minmax[0] = chromosomes[0, nummaxchromosom];
                minmax[1] = chromosomes[1, nummaxchromosom];
            }

            return minmax;
        }
        // Методы одномерного поиска
        public double[] MethodGoldenRatio(AddNewObjectOptimization mainForm)
        {
            int tempnum = 0, i = tempnum;
            double r = 0.618;
            string[] parames = new string[namevariable.Length + 1];
            double[] minmax = new double[namevariable.Length + 1];
            List<double> a = new List<double>();
            List<double> b = new List<double>();
            List<double> u = new List<double>();
            List<double> q = new List<double>();

            
            double oldrezminmax;
            if (!flagminmaxextremum)
            {
                minmax[namevariable.Length] = double.MaxValue;
                oldrezminmax = double.MaxValue;
            }
            else
            {
                minmax[namevariable.Length] = double.MinValue;
                oldrezminmax = double.MinValue;
            }
            //rgtvaluefunc = mainfunction.GetRezult().Value;
            for (int j = 0; j < namevariable.Length; j++)
            {
                parames[j] = leftboardvariable[j].ToString();
                mainfunction.SetValueVariableByName(namevariable[j], leftboardvariable[j]);
                secondRestructions.SetValueVariableByName(namevariable[j], leftboardvariable[j]);
            }
            double tempvalfunct;
            int flag = 0;
            while(true)
            {
                if (tempnum == 0)
                {
                    tempnum = namevariable.Length - 1;
                    i = 0;
                }
                else
                {
                    if (flag == 3)
                        break;
                    if (oldrezminmax == minmax[namevariable.Length])
                        flag++;
                    else
                        oldrezminmax = minmax[namevariable.Length];
                    tempnum--;
                    i = 0;
                }
                a.Clear(); b.Clear(); u.Clear(); q.Clear();
                a.Add(leftboardvariable[tempnum]);
                b.Add(rightboardvariable[tempnum]);
                u.Add(a[i] + (1 - r) * (b[i] - a[i]));
                q.Add(a[i] + r * (b[i] - a[i]));
                while (true)
                {
                    mainfunction.SetValueVariableByName(namevariable[tempnum], u[i]);
                    tempvalfunct = mainfunction.GetRezult().Value;
                    mainfunction.SetValueVariableByName(namevariable[tempnum], q[i]);
                    secondRestructions.SetValueVariableByName(namevariable[tempnum], q[i]);
                    if (!CheckingTheNewValueFunction(tempvalfunct))
                    {
                        while(!(((secondRestructions.GetRezult().Value <= maxminsecondRestr) && (flagsinssecondRest == -1)) ||
                      ((secondRestructions.GetRezult().Value == maxminsecondRestr) && (flagsinssecondRest == 0)) ||
                       ((secondRestructions.GetRezult().Value >= maxminsecondRestr) && (flagsinssecondRest == 1))))
                        {
                            q[i] = (q[i] - a[i]) * r + a[i];
                            secondRestructions.SetValueVariableByName(namevariable[tempnum], q[i]);
                        }
                        mainfunction.SetValueVariableByName(namevariable[tempnum], q[i]);
                        a.Add(a[i]);
                        b.Add(q[i]);
                        u.Add(a[i+1] + (1 - r) * (b[i+1] - a[i+1]));
                        q.Add(u[i]);
                    }
                    else
                    {
                        secondRestructions.SetValueVariableByName(namevariable[tempnum], u[i]);
                        while (!(((secondRestructions.GetRezult().Value <= maxminsecondRestr) && (flagsinssecondRest == -1)) ||
                      ((secondRestructions.GetRezult().Value == maxminsecondRestr) && (flagsinssecondRest == 0)) ||
                       ((secondRestructions.GetRezult().Value >= maxminsecondRestr) && (flagsinssecondRest == 1))))
                        {
                            u[i] = (u[i] - a[i]) * (1 - r) + a[i];
                            secondRestructions.SetValueVariableByName(namevariable[tempnum], u[i]);
                        }
                        mainfunction.SetValueVariableByName(namevariable[tempnum], u[i]);
                        a.Add(u[i]);
                        b.Add(b[i]);
                        u.Add(q[i]);
                        q.Add(a[i+1] + r * ( b[i+1] - a[i+1] ));
                    }
                    i++;
                    parames[tempnum] = Math.Round(((b[i] + a[i]) / 2), GetRoundingBit(accuracy)).ToString();
                    parames[namevariable.Length] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy)).ToString();
                    //mainForm.AddNewRowDataGridViewRezult(parames);
                    if (b[i] - a[i] <= accuracy)
                    {
                        mainfunction.SetValueVariableByName(namevariable[tempnum], (b[i] + a[i]) / 2);
                        mainfunction.SetValueVariableByName(namevariable[tempnum], (b[i] + a[i]) / 2);
                        break;
                    }
                }
                if (CheckingTheNewValueFunction(minmax[namevariable.Length]) &&
                    (((secondRestructions.GetRezult().Value <= maxminsecondRestr) && (flagsinssecondRest == -1)) ||
                      ((secondRestructions.GetRezult().Value == maxminsecondRestr) && (flagsinssecondRest == 0)) ||
                       ((secondRestructions.GetRezult().Value >= maxminsecondRestr) && (flagsinssecondRest == 1))))
                {
                    for(int j = 0; j < namevariable.Length; j++)
                        minmax[j] = Math.Round(mainfunction.GetValueVariableByName(namevariable[j]).Value, GetRoundingBit(accuracy));
                    minmax[namevariable.Length] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy));
                    flag = 0;
                }
            }
            return minmax;
        }
        public double[] MethodFibonachiNumber(AddNewObjectOptimization mainForm)
        {
            int tempnum = 0, i = tempnum;
            string[] parames = new string[namevariable.Length + 1];
            double[] minmax = new double[namevariable.Length + 1];
            List<double> a = new List<double>();
            List<double> b = new List<double>();
            List<double> x1 = new List<double>();
            List<double> x2 = new List<double>();
            List<double> numF = new List<double>();


            double oldrezminmax;
            if (!flagminmaxextremum)
            {
                minmax[namevariable.Length] = double.MaxValue;
                oldrezminmax = double.MaxValue;
            }
            else
            {
                minmax[namevariable.Length] = double.MinValue;
                oldrezminmax = double.MinValue;
            }
            //rgtvaluefunc = mainfunction.GetRezult().Value;
            for (int j = 0; j < namevariable.Length; j++)
            {
                parames[j] = leftboardvariable[j].ToString();
                mainfunction.SetValueVariableByName(namevariable[j], leftboardvariable[j]);
                secondRestructions.SetValueVariableByName(namevariable[j], leftboardvariable[j]);
            }
            double tempvalfunct;
            int flag = 0;
            while (true)
            {
                if (tempnum == 0)
                {
                    tempnum = namevariable.Length - 1;
                    i = 0;
                }
                else
                {
                    if (flag == 3)
                        break;
                    if (oldrezminmax == minmax[namevariable.Length])
                        flag++;
                    else
                        oldrezminmax = minmax[namevariable.Length];
                    tempnum--;
                    i = 0;
                }
                a.Clear(); b.Clear(); x1.Clear(); x2.Clear(); numF.Clear();
                numF.Add(1); numF.Add(1); numF.Add(numF[i] + numF[i + 1]);
                a.Add(leftboardvariable[tempnum]);
                b.Add(rightboardvariable[tempnum]);
                x1.Add(a[i] + (b[i] - a[i]) * ( numF[i] / numF[i+2] ));
                x2.Add(a[i] + (b[i] - a[i]) * (numF[i + 1] / numF[i + 2]));
                while (true)
                {
                    mainfunction.SetValueVariableByName(namevariable[tempnum], x1[i]);
                    tempvalfunct = mainfunction.GetRezult().Value;
                    mainfunction.SetValueVariableByName(namevariable[tempnum], x2[i]);
                    secondRestructions.SetValueVariableByName(namevariable[tempnum], x2[i]);
                    if (!CheckingTheNewValueFunction(tempvalfunct))
                    {
                        while (!CheckingForEntryIntoRestriction(2))
                        {
                            x2[i] = (x2[i] - a[i]) * (numF[i + 1] / numF[i + 2]) + a[i];
                            secondRestructions.SetValueVariableByName(namevariable[tempnum], x2[i]);
                        }
                        mainfunction.SetValueVariableByName(namevariable[tempnum], x2[i]);
                        a.Add(a[i]);
                        b.Add(x2[i]);
                        x1.Add(a[i] + (b[i] - x2[i]));
                        x2.Add(x1[i]);
                    }
                    else
                    {
                        secondRestructions.SetValueVariableByName(namevariable[tempnum], x1[i]);
                        while (!CheckingForEntryIntoRestriction(2))
                        {
                            x1[i] = (x1[i] - a[i]) * (numF[i] / numF[i + 2]) + a[i];
                            secondRestructions.SetValueVariableByName(namevariable[tempnum], x1[i]);
                        }
                        mainfunction.SetValueVariableByName(namevariable[tempnum], x1[i]);
                        a.Add(x1[i]);
                        b.Add(b[i]);
                        x1.Add(x2[i]);
                        x2.Add(b[i] - ( x1[i] - a[i] ));
                    }
                    i++;
                    numF.Add(numF[i] + numF[i + 1]);
                    parames[tempnum] = Math.Round(((b[i] + a[i]) / 2), GetRoundingBit(accuracy)).ToString();
                    parames[namevariable.Length] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy)).ToString();
                    //mainForm.AddNewRowDataGridViewRezult(parames);
                    if (( i > 10 ) || (b[i] - a[i] < accuracy))
                    {
                        mainfunction.SetValueVariableByName(namevariable[tempnum], (b[i] + a[i]) / 2);
                        mainfunction.SetValueVariableByName(namevariable[tempnum], (b[i] + a[i]) / 2);
                        break;
                    }
                }
                double tt = mainfunction.GetRezult().Value;
                if (CheckingTheNewValueFunction(minmax[namevariable.Length]) &&
                    CheckingForEntryIntoRestriction(2))
                {
                    for (int j = 0; j < namevariable.Length; j++)
                        minmax[j] = Math.Round(mainfunction.GetValueVariableByName(namevariable[j]).Value, GetRoundingBit(accuracy));
                    minmax[namevariable.Length] = Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy));
                    flag = 0;
                }
            }
            return minmax;
        }

        // Вспомогательные при расчетах функции
        // Получение номера лучшей/худшей хромосомы
        private int NumberMinMaxChromosomes(double[,] chromosomes, bool updateflagminmax)
        {
            int numchromosom = 0;
            double tempRez;
            if (!updateflagminmax)
            {
                mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[0, numchromosom]);
                mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[1, numchromosom]);
                tempRez = (double)mainfunction.GetRezult();
                for (int i = 1; i < 4; i++)
                {
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[0, i]);
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[1, i]);
                    if (CheckingTheNewValueFunction(tempRez)) {
                        tempRez = (double)mainfunction.GetRezult();
                        numchromosom = i;
                    }
                }
            }
            else
            {
                flagminmaxextremum = !flagminmaxextremum;
                mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[0, numchromosom]);
                mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[1, numchromosom]);
                tempRez = (double)mainfunction.GetRezult();
                for (int i = 1; i < 4; i++)
                {
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[0, i]);
                    mainfunction.SetValueVariableByName(secondRestructions.GetNameVariable(0), chromosomes[1, i]);
                    if (CheckingTheNewValueFunction(tempRez))
                    {
                        tempRez = (double)mainfunction.GetRezult();
                        numchromosom = i;
                    }
                }
                flagminmaxextremum = !flagminmaxextremum;
            }
            return numchromosom;
        }
        // Получение количества разрядов в точности
        public static int GetRoundingBit(double value)
        {
            int countRaundingBit = 0;
            while(value < 1)
            {
                value *= 10;
                countRaundingBit++;
            }
            return countRaundingBit;
        }
        // Сравнение значений целевой функции
        private bool CheckingTheNewValueFunction(double valueForComparison)
        {
            bool flag = false;
            if (!flagminmaxextremum)
            {
                if (valueForComparison > Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy)))
                    flag = true;
            }
            else
                if (valueForComparison < Math.Round(mainfunction.GetRezult().Value, GetRoundingBit(accuracy)))
                    flag = true;
            return flag;
        }
        // Проверка выполнения ограничения первого или второго рода
        private bool CheckingForEntryIntoRestriction(int numberrestriction)
        {
            bool flag = false;
            if ((numberrestriction == 1) &&
                mainfunction.GetValueVariableByName(secondRestructions.GetNameVariable(0)).Value >= leftboardvariable[0] &&
                mainfunction.GetValueVariableByName(secondRestructions.GetNameVariable(0)).Value <= rightboardvariable[0] &&
                mainfunction.GetValueVariableByName(secondRestructions.GetNameVariable(1)).Value >= leftboardvariable[1] &&
                mainfunction.GetValueVariableByName(secondRestructions.GetNameVariable(1)).Value <= rightboardvariable[1])
                flag = true;
            else if ((numberrestriction == 2) &&
                    (((secondRestructions.GetRezult().Value <= maxminsecondRestr) && (flagsinssecondRest == -1)) ||
                    ((secondRestructions.GetRezult().Value == maxminsecondRestr) && (flagsinssecondRest == 0)) ||
                    ((secondRestructions.GetRezult().Value >= maxminsecondRestr) && (flagsinssecondRest == 1))))
                flag = true;
            return flag;
        }

    }
}
