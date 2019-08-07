## Taxi Fare

```bash
wget https://raw.githubusercontent.com/dotnet/machinelearning-samples/master/samples/csharp/getting-started/Regression_TaxiFarePrediction/TaxiFarePrediction/Data/taxi-fare-train.csv -P resource

mlnet auto-train \
    --task regression \
    --dataset "resource/taxi-fare-train.csv" \
    --label-column-name "fare_amount" \
    --max-exploration-time 10 \
    --output-path src
```