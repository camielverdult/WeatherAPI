﻿using System;

public class Metadata
{
    public DateTime UTCTimeStamp { get; set; }
    public string DeviceID { get; set; }
    public string ApplicationID { get; set; }
    public string GatewayID { get; set; }

    public Metadata(DateTime timestamp, string deviceID, string applicationID, string gatewayID)
    {
        UTCTimeStamp = timestamp;
        DeviceID = deviceID;
        ApplicationID = applicationID;
        GatewayID = gatewayID;
    }
}

public class Positional
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double? Altitude { get; set; }
    public Positional(double latitude, double longitude, double altitude)
    {
        Latitude = latitude;
        Longitude = longitude;
        Altitude = altitude;
    }

    public Positional(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
}

public class SensorData
{
    public int? LightLogscale { get; set; }
    public int? LightLux { get; set; }
    public float Temperature { get; set; }
    public float? Humidity { get; set; }
    public float? Pressure { get; set; }
    public int? BatteryStatus { get; set; }
    public float? BatteryVoltage { get; set; }
    public string? WorkMode { get; set; }

    public SensorData(float temperature, float humidity, int lightLux, int batteryStatus, 
        float batteryVoltage, string workMode)
    {
        LightLux = lightLux;
        Temperature = temperature;
        Humidity = humidity;
        BatteryStatus = batteryStatus;
        BatteryVoltage = batteryVoltage;
        WorkMode = workMode;
    }

    public SensorData(float temperature, float pressure, int lightLog)
    {
        Temperature = temperature;
        Pressure = pressure; 
        LightLogscale = lightLog;
    }
}

public class TransmissionalData
{
    public int Rssi { get; set; }
    public float? Snr { get; set; }
    public int SpreadingFactor { get; set; }
    public float ConsumedAirtime { get; set; }
    public int Bandwidth { get; set; }
    public int Frequency { get; set; }

    public TransmissionalData(int rssi, float snr, int spreadingFactor, 
        float consumedAirtime, int bandwidth, int frequency)
    {
        Rssi = rssi;
        Snr = snr;
        SpreadingFactor = spreadingFactor;
        ConsumedAirtime = consumedAirtime;
        Bandwidth = bandwidth;
        Frequency = frequency;
    }

    public TransmissionalData(int rssi, int spreadingFactor,
        float consumedAirtime, int bandwidth, int frequency)
    {
        Rssi = rssi;
        SpreadingFactor = spreadingFactor;
        ConsumedAirtime = consumedAirtime;
        Bandwidth = bandwidth;
        Frequency = frequency;
    }
}

public class WeatherPoint
{

    public Metadata Metadata { get; set; }
    public Positional Positional { get; set; }
    public SensorData SensorData { get; set; }
    public TransmissionalData TransmissionalData { get; set; }

    public WeatherPoint(Metadata metadata, Positional positional, SensorData sensorData, TransmissionalData transmissionalData)
    {
        Metadata = metadata;
        Positional = positional;
        SensorData = sensorData;
        TransmissionalData = transmissionalData;
    }

}
