﻿using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;

// Store connection information
string endpoint = "<Endpoint URL>";
string apiKey = "<API Key>";
Uri fileUri = new Uri("https://raw.githubusercontent.com/Azure-Samples/cognitive-services-REST-api-samples/master/curl/form-recognizer/sample-invoice.pdf");

Console.WriteLine("Connecting to Forms Recognizer at: {0}", endpoint);
Console.WriteLine("Analyzing invoice at: {0}", fileUri.ToString());

// Create the client

// Analyze the invoice

// Display invoice information to the user



if (invoice.Fields.TryGetValue("CustomerName", out DocumentField customerNameField))
{
    if (customerNameField.ValueType == DocumentFieldType.String)
    {
        string customerName = customerNameField.AsString();
        Console.WriteLine($"Customer Name: '{customerName}', with confidence {customerNameField.Confidence}.");
    }
}

if (invoice.Fields.TryGetValue("InvoiceTotal", out DocumentField invoiceTotalField))
{
    if (invoiceTotalField.ValueType == DocumentFieldType.Currency)
    {
        CurrencyValue invoiceTotal = invoiceTotalField.AsCurrency();
        Console.WriteLine($"Invoice Total: '{invoiceTotal.Symbol}{invoiceTotal.Amount}', with confidence {invoiceTotalField.Confidence}.");
    }
}

Console.WriteLine("Analysis complete.");