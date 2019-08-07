//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using SampleRegression.Model.DataModels;


namespace SampleRegression.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput
            {
                Vendor_id = "CMT",
                Rate_code = 1,
                Passenger_count = 2,
                Trip_time_in_secs = 800,
                Trip_distance = 2,
                Payment_type = "CRD"
            };

            ConsumeModel(input);
        }

        static void ConsumeModel(ModelInput input)
        {
            var context = new MLContext();
            var model = context.Model.Load($"./src/SampleRegression/SampleRegression.Model/MLModel.zip", out var schema);
            var prediction = context.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);

            var result = prediction.Predict(input);

            var score = result.Score;
            Console.WriteLine($"Text: {input.Vendor_id} | Predcition: {score}");
        }
    }
}
