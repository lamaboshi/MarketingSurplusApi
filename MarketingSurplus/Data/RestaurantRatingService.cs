using Microsoft.ML;
using Microsoft.ML.Data;

namespace MarketingSurplus.Data
{
    public class UserData
    {
        public float TotalAmount { get; set; }
        public float PurchaseFrequency { get; set; }
        // Add other features as needed
    }

    public class CompanyPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint CompanyID { get; set; }
    }


    public class CompanyRecommendationModel
    {
        private readonly PredictionEngine<UserData, CompanyPrediction> _predictionEngine;

        public CompanyRecommendationModel()
        {
            //var mlContext = new MLContext();

            //try
            //{
            //    var modelPath = "../MarketingSurplus/company_recommendation_model.onnx";
            //    Console.WriteLine($"Model Path: {modelPath}"); // Debugging output
            //    if (!File.Exists(modelPath))
            //    {
            //        throw new FileNotFoundException("Model file not found.", modelPath);
            //    }

            //    var onnxModel = mlContext.Model.Load(modelPath, out var inputSchema);
            //    _predictionEngine = mlContext.Model.CreatePredictionEngine<UserData, CompanyPrediction>(onnxModel);
            //    Console.WriteLine("Model loaded successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred while loading the model: {ex.Message}");
            //    throw;
            //}
        }

        public uint Predict(UserData input)
        {
            try
            {
                var prediction = _predictionEngine.Predict(input);
                return prediction.CompanyID;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during prediction: {ex.Message}");
                throw;
            }
        }
    }
}
