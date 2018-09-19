﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastText.NetWrapper;

namespace TestUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            var fastText = new FastTextWrapper();

            //fastText.Train(@"C:\Models\ehd_small_ft.txt", @"C:\Models\ehd", TrainingArgs.SupervisedDefaults(x =>
            //{
            //    x.Epochs = 25;
            //    x.LearningRate = 1.0;
            //    x.WordNGrams = 3;
            //    x.Verbose = 2;
            //    x.LabelPrefix = "__label__";
            //}));

            fastText.LoadModel(@"C:\Models\ehd.bin");
            var labels = fastText.GetLabels();
            var prediction = fastText.PredictSingle("не работает монитор");
            var predictions = fastText.PredictMultiple("не работает монитор", 4);
            var vector = fastText.GetSentenceVector("не работает монитор");
        }
    }
}
