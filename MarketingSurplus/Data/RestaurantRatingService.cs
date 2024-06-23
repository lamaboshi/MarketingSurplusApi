using Microsoft.ML;

namespace MarketingSurplus.Data
{
    public class RestaurantRatingService
    {
        private readonly MLContext _mlContext;
        private readonly string _dataPath;
        private readonly string _modelPath;

        public RestaurantRatingService(MLContext mlContext, string dataPath, string modelPath)
        {
            _mlContext = mlContext;
            _dataPath = dataPath;
            _modelPath = modelPath;
        }

        public ITransformer BuildAndTrainModel()
        {
            var dataView = _mlContext.Data.LoadFromTextFile<RestaurantData>(_dataPath, hasHeader: true, separatorChar: ',');
            var pipeline = _mlContext.Transforms.Conversion.MapValueToKey(inputColumnName: "Rating", outputColumnName: "Label")
                .Append(_mlContext.Transforms.Text.FeaturizeText(inputColumnName: "RestaurantName", outputColumnName: "Features"))
                .Append(_mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var model = pipeline.Fit(dataView);
            _mlContext.Model.Save(model, dataView.Schema, _modelPath);

            return model;
        }
    }
    public class RestaurantData
    {
        public float Rating { get; set; }
        public string RestaurantName { get; set; }
    }

    public class RestaurantPrediction
    {
        public float Rating { get; set; }
        public string RestaurantName { get; set; }
        public float Score { get; set; }
    }
}
